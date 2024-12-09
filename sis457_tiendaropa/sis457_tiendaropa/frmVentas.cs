using CadTiendaropa;
using ClnTiendaropa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sis457_tiendaropa
{
    public partial class frmVentas : Form
    {
        private List<DetalleVenta> detalles = new List<DetalleVenta>();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarProductos();
            CargarVentas(); // Cargar las ventas al iniciar el formulario
            motototal.Text = "0.00";
            textmotopago.Text = "0.00";
            montocambio.Text = "0.00";
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = new UsuarioCln().listar();
            combusuario.DataSource = usuarios;
            combusuario.DisplayMember = "usuario1";
            combusuario.ValueMember = "id";
        }

        private void CargarProductos()
        {
            List<Producto> productos = new ProductoCln().listar();
            combproducto.DataSource = productos;
            combproducto.DisplayMember = "nombre";
            combproducto.ValueMember = "id";
        }

        private void CargarVentas()
        {
            List<Venta> ventas = VentaCln.GetAll();
            List<Producto> productos = new ProductoCln().listar();
            dgvdata.Rows.Clear();
            foreach (var venta in ventas)
            {
                dgvdata.Rows.Add(venta.id, venta.idUsuario, venta.tipoDocumento, venta.numeroDocumento,
                                 venta.documentoCliente, venta.nombreCliente, venta.montoPago,
                                 venta.montoCambio, venta.montoTotal, venta.estado == 1 ? "Activo" : "Inactivo");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta
                {
                    idUsuario = (int)combusuario.SelectedValue,
                    tipoDocumento = texttipodoc.Text,
                    numeroDocumento = textnumerodocumento.Text,
                    documentoCliente = textdocumentocliente.Text,
                    nombreCliente = textnombrecliente.Text,
                    montoPago = decimal.Parse(textmotopago.Text),
                    montoCambio = decimal.Parse(montocambio.Text),
                    montoTotal = decimal.Parse(motototal.Text),
                    usuarioRegistro = "usuario_actual",
                    fechaRegistro = DateTime.Now,
                    estado = checkestado.Checked ? (short)1 : (short)0
                };

                VentaCln.Insert(venta);
                MessageBox.Show("Venta guardada correctamente", "Guardar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarVentas(); // Actualizar el DataGridView después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
        
            VentaCln.Delete(Convert.ToInt32(textVentaId.Text));
            MessageBox.Show("Venta eliminada correctamente", "Eliminar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
            CargarVentas(); 
        }

        private void LimpiarFormulario()
        {
            textVentaId.Clear();
            texttipodoc.Clear();
            textnumerodocumento.Clear();
            textdocumentocliente.Clear();
            textnombrecliente.Clear();
            motototal.Text = "0.00";
            textmotopago.Text = "0.00";
            montocambio.Text = "0.00";
            detalles.Clear();
            dgvdata.Rows.Clear();
        }

        private void CalcularTotal()
        {
            decimal total = detalles.Sum(d => d.subTotal);
            motototal.Text = total.ToString("0.00");

            if (decimal.TryParse(textmotopago.Text, out decimal pago))
            {
                montocambio.Text = (pago - total).ToString("0.00");
            }
            else
            {
                montocambio.Text = "0.00";
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int ventaId = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["id"].Value);
                Venta venta = VentaCln.GetById(ventaId);

                if (venta != null)
                {
                    textVentaId.Text = venta.id.ToString();
                    combusuario.SelectedValue = venta.idUsuario;
                    texttipodoc.Text = venta.tipoDocumento;
                    textnumerodocumento.Text = venta.numeroDocumento;
                    textdocumentocliente.Text = venta.documentoCliente;
                    textnombrecliente.Text = venta.nombreCliente;
                    textmotopago.Text = venta.montoPago.ToString();
                    montocambio.Text = venta.montoCambio.ToString();
                    motototal.Text = venta.montoTotal.ToString();
                    checkestado.Checked = venta.estado == 1;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}