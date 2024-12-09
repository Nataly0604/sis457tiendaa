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
using CadTiendaropa;
using ClnTiendaropa;

namespace sis457_tiendaropa
{
    public partial class frmDetalleVentas : Form
    {
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            List<Venta> Ventas = VentaCln.GetAll();
            dgvdata.Rows.Clear();
            foreach (Venta item in Ventas)
            {
                dgvdata.Rows.Add(new object[] { "", item.id, item.idUsuario, item.tipoDocumento,
                    item.numeroDocumento, item.documentoCliente, item.nombreCliente, item.montoPago,
                    item.montoCambio,
                    item.montoTotal, item.estado == 1 ? "Activo" : "Inactivo", item.estado });


            }
        }
    }
}
