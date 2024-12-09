
﻿using sis457_tiendaropa.utilidades;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClnTiendaropa;
using CadTiendaropa;



namespace sis457_tiendaropa
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 0;

            List<Rol> listaRol = new RoleCln().listar();
            foreach (Rol item in listaRol)
            {
                combrol.Items.Add(new opcionCombo() { Text = item.descripcion, Value = item.idRol });
                combrol.DisplayMember = "Text";
                combrol.ValueMember = "Value";
                combrol.SelectedIndex = 0;
            }

          

            CargarUsuarios();


        }
        private void CargarUsuarios()
        {
           
            List<Usuario> usuarios = new UsuarioCln().listar();
            dgvdata.Rows.Clear();
            foreach (Usuario item in usuarios)
            {
                dgvdata.Rows.Add(new object[] { "", item.id, item.usuario1, item.Rol.descripcion,
                    item.estado == 1 ? "Activo" : "Inactivo",
                    item.estado, item.idRol, item.clave });
            }
        }

      

        private void btnguardar_Click(object sender, EventArgs e)
        {


            Usuario usuario = new Usuario
            {
                usuario1 = textusuario.Text,
                clave = textclave.Text,
                idRol = Convert.ToInt32(((opcionCombo)combrol.SelectedItem).Value),
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = "empleado", // Asegúrate de reemplazar esto con el valor adecuado
                fechaRegistro = DateTime.Now // Solo para nuevas inserciones
            };

         
                new UsuarioCln().crear(usuario);
                MessageBox.Show("Usuario creado correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          

   
            CargarUsuarios();
            limpiar();
        }

        private void limpiar()
        {
            textid.Text = "";
            textusuario.Text = "";
            textclave.Text = "";
            combestado.SelectedIndex = 0;
            combrol.SelectedIndex = 0;
        }

        private void cbobusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                // controlar el tamaño 

                var w = 16;
                var h = 16;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.login_ok, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textid.Text = dgvdata.Rows[indice].Cells["id"].Value.ToString();
                    textusuario.Text = dgvdata.Rows[indice].Cells["usuario"].Value.ToString();
                    textclave.Text = dgvdata.Rows[indice].Cells["clave"].Value.ToString();

                    foreach (opcionCombo oc in combestado.Items)
                    {
                        if (Convert.ToInt32(oc.Value) == Convert.ToInt32(dgvdata.Rows[indice].Cells["estadovalor"].Value))
                        {
                            int indiceCombo = combestado.Items.IndexOf(oc);
                            combestado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (opcionCombo oc in combrol.Items)
                    {
                        if (Convert.ToInt32(oc.Value) == Convert.ToInt32(dgvdata.Rows[indice].Cells["idRol"].Value))
                        {
                            int indiceCombo = combrol.Items.IndexOf(oc);
                            combrol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
            else if (dgvdata.Columns[e.ColumnIndex].Name == "eliminar")
            {
                int id = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                DialogResult result = MessageBox.Show("¿Deseas eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    new UsuarioCln().eliminar(id);
                    MessageBox.Show("Usuario eliminado correctamente", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
            }
        
    }

       

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
                // eliminar en l abase de datos 
                new UsuarioCln().eliminar(Convert.ToInt32(textid.Text));
            MessageBox.Show("Usuario eliminado correctamente", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                limpiar();
         


        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                id = Convert.ToInt32(textid.Text),
                usuario1 = textusuario.Text,
                clave = textclave.Text,
                idRol = Convert.ToInt32(((opcionCombo)combrol.SelectedItem).Value),
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = "empleado", // Asegúrate de reemplazar esto con el valor adecuado
                fechaRegistro = DateTime.Now // Solo para nuevas inserciones
            };
           


            new UsuarioCln().actualizar(usuario);
            MessageBox.Show("Usuario actualizado correctamente", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescar el DataGridView
            CargarUsuarios();
            limpiar();

        }

    }

}
