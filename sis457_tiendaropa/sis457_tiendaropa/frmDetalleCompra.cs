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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

     
           
         
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            List<Compra> Compras = new CompraCln().listar();
            dgvCompras.Rows.Clear();
            foreach (Compra item in Compras)
            {
                dgvCompras.Rows.Add(new object[] { "", item.id, item.idUsuario, item.idProveedor, item.tipoDocumento, item.numeroDocumento, item.montoTotal, item.usuarioRegistro,
                   item.fechaRegistro, item.estado == 1 ? "Activo" : "Inactivo", item.estado });
            }
        }
    }
}
        
    