using sis457_tiendaropa.utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CadTiendaropa;
using ClnTiendaropa;
using System.Windows.Forms;

namespace sis457_tiendaropa
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // Configurar combobox de estado
            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 1;

            // Cargar categorías en el DataGridView
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgvdata.Rows.Clear();
            List<Categoria> categorias = new CategoriaCln().listar();

            foreach (var item in categorias)
            {
                dgvdata.Rows.Add(new object[] {
                    "", item.id, item.descripcion,
                    item.estado == 1 ? "Activo" : "Inactivo",
                    item.estado
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                descripcion = txtdescripcion.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            new CategoriaCln().crear(categoria);
            MessageBox.Show("Categoría creada correctamente", "Guardar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la lista de categorías y limpiar los campos
            CargarCategorias();
            Limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                id = Convert.ToInt32(txtid.Text),
                descripcion = txtdescripcion.Text,
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
            };

            new CategoriaCln().actualizar(categoria);
            MessageBox.Show("Categoría actualizada correctamente", "Editar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la lista de categorías y limpiar los campos
            CargarCategorias();
            Limpiar();
        }

        private void Limpiar()
        {
            txtid.Text = "";
            txtdescripcion.Text = "";
            combestado.SelectedIndex = 1;
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Seleccionar una categoría desde el DataGridView
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int id = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Categoria categoria = new CategoriaCln().obtenerPorId(id);

                // Llenar los campos del formulario con la información de la categoría seleccionada
                txtid.Text = categoria.id.ToString();
                txtdescripcion.Text = categoria.descripcion;
                combestado.SelectedIndex = categoria.estado == 1 ? 1 : 0;
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            new CategoriaCln().eliminar(Convert.ToInt32(txtid.Text));
            MessageBox.Show("Categoría eliminada correctamente", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la lista de categorías y limpiar los campos
            CargarCategorias();
            Limpiar();
        }
    }
}