using CadTiendaropa;
using ClnTiendaropa;
using sis457_tiendaropa.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis457_tiendaropa
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 1; // Selecciona "Activo" como valor predeterminado

            CargarProveedores();

        }

        private void CargarProveedores()
        {
            dgvdata.Rows.Clear();
            List<Proveedor> proveedores = new ProveedorCln().listar();

            foreach (var item in proveedores)
            {
                dgvdata.Rows.Add(new object[] {
                    "", item.id, item.documento, item.razonSocial,
                    item.email, item.telefono,
                    item.estado == 1 ? "Activo" : "Inactivo",
                    item.estado
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


            Proveedor proveedor = new Proveedor
            {
                documento = textdocumento.Text,
                razonSocial = textrazonsocial.Text,
                email = textemail.Text,
                telefono = texttelefono.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            if (string.IsNullOrEmpty(textid.Text)) // Nuevo proveedor
            {
                new ProveedorCln().crear(proveedor);
                MessageBox.Show("Proveedor creado correctamente", "Guardar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Actualizar proveedor
            {
                proveedor.id = Convert.ToInt32(textid.Text);
                new ProveedorCln().actualizar(proveedor);
                MessageBox.Show("Proveedor actualizado correctamente", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarProveedores();
            Limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            Proveedor proveedor = new Proveedor
            {
                id = Convert.ToInt32(textid.Text),
                documento = textdocumento.Text,
                razonSocial = textrazonsocial.Text,
                email = textemail.Text,
                telefono = texttelefono.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            new ProveedorCln().actualizar(proveedor);
            MessageBox.Show("proveedor actualizo correctamente", "Guardar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);


            CargarProveedores();
            Limpiar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textid.Text))
            {
                int id = Convert.ToInt32(textid.Text);
                new ProveedorCln().eliminar(id);
                MessageBox.Show("Proveedor eliminado correctamente", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Limpiar()
        {
            textid.Text = "";
            textdocumento.Text = "";
            textrazonsocial.Text = "";
            textemail.Text = "";
            texttelefono.Text = "";
            combestado.SelectedIndex = 1;
        }
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int id = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Proveedor proveedor = new ProveedorCln().obtenerPorId(id);

                textid.Text = proveedor.id.ToString();
                textdocumento.Text = proveedor.documento;
                textrazonsocial.Text = proveedor.razonSocial;
                textemail.Text = proveedor.email;
                texttelefono.Text = proveedor.telefono;
                combestado.SelectedIndex = proveedor.estado == 1 ? 1 : 0;
            }
        }


    }
}