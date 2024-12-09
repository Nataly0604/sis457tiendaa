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

    public partial class frmcompras : Form
    {
        private List<DetalleCompra> detalles = new List<DetalleCompra>();

        public frmcompras()
        {
            InitializeComponent();
        }

        private void frmcompras_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarProveedores();
            CargarProductos();

            combestado.Items.Add(new opcionCombo() { Text = "Inactivo", Value = 0 });
            combestado.Items.Add(new opcionCombo() { Text = "Activo", Value = 1 });
            combestado.DisplayMember = "Text";
            combestado.ValueMember = "Value";
            combestado.SelectedIndex = 1;

            combtipodocumento.Items.Add("Factura");
       



            combtipodocumento.SelectedIndex = 0;

            fecharegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = new UsuarioCln().listar();
            combusuario.DataSource = usuarios;
            combusuario.DisplayMember = "usuario1";
            combusuario.ValueMember = "id";
        }

        private void CargarProveedores()
        {
            List<Proveedor> proveedores = new ProveedorCln().listar();
            comproveedor.DataSource = proveedores;
            comproveedor.DisplayMember = "razonSocial";
            comproveedor.ValueMember = "id";
        }

        private void CargarProductos()
        {
            List<Producto> productos = new ProductoCln().listar();
            combproducto.DataSource = productos;
            combproducto.DisplayMember = "nombre";
            combproducto.ValueMember = "id";
        }


        private void agregarproducto_Click(object sender, EventArgs e)
        {
            if (combproducto.SelectedItem == null || numericcantidad.Value <= 0 || numericcompraprecio.Value <= 0)
            {
                MessageBox.Show("Seleccione un producto y establezca cantidad y precio correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = (Producto)combproducto.SelectedItem;
            int cantidad = (int)numericcompraprecio.Value;
            decimal precioCompra = numericcompraprecio.Value;
            decimal subtotal = cantidad * precioCompra;

            DetalleCompra detalle = new DetalleCompra
            {
                idProducto = producto.id,
                cantidad = cantidad,
                precioCompra = precioCompra,
                total = subtotal
            };
            detalles.Add(detalle);

            dgvdata.Rows.Add("",producto.id, producto.nombre, precioCompra, cantidad, subtotal);
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = detalles.Sum(d => d.total);
            motototal.Text = total.ToString("0.00");
        }


   
        private void LimpiarFormulario()
        {
            textnumerodocumento.Text = "";
            combusuario.SelectedIndex = 0;
            comproveedor.SelectedIndex = 0;
            combproducto.SelectedIndex = 0;
            numericcompraprecio.Value = 0;
            numericcantidad.Value = 0;
            motototal.Text = "0.00";
            detalles.Clear();
            dgvdata.Rows.Clear();
        }
        private bool mostrandoDetalles = true;
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Verifica si estamos en la vista de detalles
            if (!mostrandoDetalles && dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                // Obtener el ID de la compra seleccionada
                int compraId = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Compra compra = new CompraCln().obtenerPorId(compraId);

                // Muestra los datos generales de la compra
                textCompraId.Text = compra.id.ToString();
                combusuario.SelectedValue = compra.idUsuario;
                comproveedor.SelectedValue = compra.idProveedor;
                combtipodocumento.Text = compra.tipoDocumento;
                textnumerodocumento.Text = compra.numeroDocumento;
                combestado.SelectedIndex = compra.estado == 1 ? 1 : 0;

                // Cambia el `DataGridView` para mostrar los detalles de la compra
                dgvdata.Rows.Clear();
                foreach (var detalle in compra.DetalleCompra)
                {
                    Producto producto = new ProductoCln().obtenerPorId(detalle.idProducto);
                    dgvdata.Rows.Add(producto.nombre, detalle.precioCompra, detalle.cantidad, detalle.total);
                }

                // Actualizar el total
                CalcularTotal();

                mostrandoDetalles = true; // Cambia a modo de vista de detalles
            }
            else if (mostrandoDetalles) // Si ya estamos en la vista de detalles, volvemos a la vista general
            {
                // Volver a cargar la vista general de compras
                CargarCompras(); // Este método debe recargar la lista general de compras en `dgvdata`
                mostrandoDetalles = false;
            }
        }
        private void CargarCompras()
        {
            dgvdata.Rows.Clear();
            List<Compra> compras = new CompraCln().listar();
            foreach (var compra in compras)
            {
                dgvdata.Rows.Add(compra.id, compra.idUsuario, compra.idProveedor, compra.tipoDocumento, compra.numeroDocumento, compra.montoTotal, compra.estado);
            }
        }

        private void editarcompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCompraId.Text))
            {
                MessageBox.Show("Seleccione una compra para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int compraId = int.Parse(textCompraId.Text);
            Compra compra = new CompraCln().obtenerPorId(compraId);

            compra.tipoDocumento = combtipodocumento.SelectedItem.ToString();
            compra.numeroDocumento = textnumerodocumento.Text;
            compra.montoTotal = decimal.Parse(motototal.Text);
            compra.estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value);

            new CompraCln().actualizar(compra);
            MessageBox.Show("Compra actualizada correctamente", "Editar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void eliminarcompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCompraId.Text))
            {
                MessageBox.Show("Seleccione una compra para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int compraId = int.Parse(textCompraId.Text);
            new CompraCln().eliminar(compraId);
            MessageBox.Show("Compra eliminada correctamente", "Eliminar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void guardarcompra_Click_1(object sender, EventArgs e)
        {
            Compra compra = new Compra
            {
                idUsuario = (int)combusuario.SelectedValue,
                idProveedor = (int)comproveedor.SelectedValue,
                tipoDocumento = combtipodocumento.SelectedItem.ToString(),
                numeroDocumento = textnumerodocumento.Text,
                montoTotal = decimal.Parse(motototal.Text),
                estado = (short)Convert.ToInt32(((opcionCombo)combestado.SelectedItem).Value),
                usuarioRegistro = "usuario_actual",
                fechaRegistro = DateTime.Now
            };

            new CompraCln().crear(compra);
            MessageBox.Show("Compra registrada correctamente", "Guardar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}