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
using System.Windows.Controls;
using System.Windows.Forms;

namespace sis457_tiendaropa
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 1;

            CargarClientes();
        }
        private void CargarClientes()
        {
            dgvdata.Rows.Clear();
            List<Cliente> clientes = new ClienteCln().listar();

            foreach (var item in clientes)
            {
                dgvdata.Rows.Add(new object[] {
                    "", item.id, item.documento, item.nombreCompleto,
                    item.email, item.telefono, item.direccion,
                    item.estado == 1 ? "Activo" : "Inactivo", item.estado
                });
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente
            {
                documento = textdocumento.Text,
                nombreCompleto = textnombrecompleto.Text,
                email = textemail.Text,
                telefono = texttelefono.Text,
                direccion = textireccion.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = "usuario_actual",
                fechaRegistro = DateTime.Now
            };

            if (string.IsNullOrEmpty(textid.Text))
            {
                new ClienteCln().crear(cliente);
                MessageBox.Show("Cliente creado correctamente", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            CargarClientes();
            Limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {


            Cliente producto = new Cliente
            {
                id = Convert.ToInt32(textid.Text),
                documento = textdocumento.Text,
                nombreCompleto = textnombrecompleto.Text,
                email = textemail.Text,
                telefono = texttelefono.Text,
                direccion = textireccion.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            new ClienteCln().actualizar(producto);
            MessageBox.Show("Producto actualizo correctamente", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);



            CargarClientes();
            Limpiar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textid.Text))
            {
                int id = Convert.ToInt32(textid.Text);
                new ClienteCln().eliminar(id);
                MessageBox.Show("Cliente eliminado correctamente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int id = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Cliente cliente = new ClienteCln().obtenerPorId(id);

                textid.Text = cliente.id.ToString();
                textdocumento.Text = cliente.documento;
                textnombrecompleto.Text = cliente.nombreCompleto;
                textemail.Text = cliente.email;
                texttelefono.Text = cliente.telefono;
                textireccion.Text = cliente.direccion;
                combestado.SelectedIndex = cliente.estado == 1 ? 1 : 0;
            }
        }

        private void Limpiar()
        {
            textid.Text = "";
            textdocumento.Text = "";
            textnombrecompleto.Text = "";
            textemail.Text = "";
            texttelefono.Text = "";
            textireccion.Text = "";
            combestado.SelectedIndex = 1;
        }
    }
}
