using CadTiendaropa;

using ClnTiendaropa;

using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {


        public static Usuario  usuarioActual;
        private static IconMenuItem menuActual=null;
        private static Form formularioActual = null;

      
            //if (objusuario == null)
            //    usuarioActual = new Usuario() { usuarioRegistro = "ADMIN", id = 1, usuario1 = "ADMIN", clave="123" };
            //else
              //  usuarioActual = objusuario;


        public Inicio(Usuario objusuario)
        {
            usuarioActual=objusuario;

            InitializeComponent();
        }


        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
          
            menuActual=menu;
            if (formulario != null)
            {
                formularioActual = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                contenedor.Controls.Add(formulario);
                contenedor.Tag = formulario;
                formulario.BringToFront();
                formulario.Show();
            }


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> listapermisos = new PermisosCln().listar(usuarioActual.id);

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado=listapermisos.Any(x => x.nombreMenu == iconmenu.Name);
                if (encontrado)
                {
                    iconmenu.Visible = true;
                }
                else
                {
                    iconmenu.Visible = false;
                }
            }

            userActual.Text = usuarioActual.usuario1;
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }


        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmCategoria());

        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {

            abrirFormulario((IconMenuItem)sender, new frmProducto());

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmVentas());
        }

        private void submenuverdetalle_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmDetalleVentas());
        }

        private void submenuregistraventa_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmcompras());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuventas_Click(object sender, EventArgs e)
        {

        }

        private void submenuCategoria_Click_1(object sender, EventArgs e)
        {
            frmCategoria categoriaForm = new frmCategoria();

            // Mostrar el formulario de forma independiente
            categoriaForm.Show();
            
        }

        private void submenuProducto_Click_1(object sender, EventArgs e)
        {

            new frmProducto().ShowDialog();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {

     
                new frmUsuarios().ShowDialog();
            


        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
