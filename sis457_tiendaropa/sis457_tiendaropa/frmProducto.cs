using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadTiendaropa;
using ClnTiendaropa;
using sis457_tiendaropa.utilidades;

namespace sis457_tiendaropa
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }



        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Cargar categorías en el ComboBox
            List<Categoria> categorias = new CategoriaCln().listar();
            combcategoria.DataSource = categorias;
            combcategoria.DisplayMember = "descripcion";
            combcategoria.ValueMember = "id";

            // Configuración de estado
            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 1;

            // Cargar productos en el DataGridView
            CargarProductos();

        }
        private void CargarProductos()
        {
            dgvdata.Rows.Clear();
            List<Producto> productos = new ProductoCln().listar();

            foreach (var item in productos)
            {
                dgvdata.Rows.Add(new object[] {
                    "", item.id, item.nombre, item.codigo,item.descripcion,
                    item.Categoria.descripcion, item.stock,
                    item.precioVenta, item.estado == 1 ? "Activo" : "Inactivo",
                    item.estado
                });
            }
        }
        private void Limpiar()
        {
            textid.Text = "";
            textnombre.Text = "";
            textcodigo.Text = "";
            textdescripcion.Text = "";
            textstock.Text = "";
            textprecioventa.Text = "";
            combcategoria.SelectedIndex = 0;
            combestado.SelectedIndex = 1;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto
            {
                nombre = textnombre.Text,
                codigo = textcodigo.Text,
                descripcion = textdescripcion.Text,
                stock = int.Parse(textstock.Text),
                precioVenta = decimal.Parse(textprecioventa.Text),
                idCategoria = Convert.ToInt32(combcategoria.SelectedValue),
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),

                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            if (string.IsNullOrEmpty(textid.Text))
            {
                new ProductoCln().crear(producto);
                MessageBox.Show("Producto creado correctamente", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            CargarProductos();
            Limpiar();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                id = Convert.ToInt32(textid.Text),
                nombre = textnombre.Text,
                codigo = textcodigo.Text,
                descripcion = textdescripcion.Text,
                stock = int.Parse(textstock.Text),
                precioVenta = decimal.Parse(textprecioventa.Text),
                idCategoria = Convert.ToInt32(combcategoria.SelectedValue),
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),

                usuarioRegistro = Inicio.usuarioActual.usuario1,
                fechaRegistro = DateTime.Now
            };

            new ProductoCln().actualizar(producto);
            MessageBox.Show("Producto actualizo correctamente", "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);



            CargarProductos();
            Limpiar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textid.Text);
            new ProductoCln().eliminar(id);
            MessageBox.Show("Producto eliminado correctamente", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarProductos();
            Limpiar();



            CargarProductos();
            Limpiar();

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int id = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Producto producto = new ProductoCln().obtenerPorId(id);

                textid.Text = producto.id.ToString();
                textnombre.Text = producto.nombre;
                textcodigo.Text = producto.codigo;
                textdescripcion.Text = producto.descripcion;
                textstock.Text = producto.stock.ToString();
                textprecioventa.Text = producto.precioVenta.ToString();
                combcategoria.SelectedValue = producto.idCategoria;
                combestado.SelectedIndex = producto.estado == 1 ? 1 : 0;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textbuscar.Text);
            Producto resultado = new ProductoCln().obtenerPorId(id); if (resultado != null)
            {
                dgvdata.DataSource = new List<Producto> { resultado }; // Para mostrar el resultado en el DataGridView // MessageBox.Show("Producto cargado correctamente", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                CargarProductos();
                Limpiar();





            }
        }
    }
}
