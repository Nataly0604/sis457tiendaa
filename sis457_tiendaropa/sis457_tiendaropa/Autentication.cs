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
    public partial class Autentication : Form
    {
        public Autentication()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

         
            // Obtener el usuario y clave ingresados
            string usuario = txtnombre.Text;
            string clave = txtclave.Text;

           
            var usuarioValido = UsuarioCln.validar(usuario, clave);
   



            if (usuarioValido != null)
            {
               
                Inicio f = new Inicio(usuarioValido);
                f.Show();
                this.Hide();

                f.FormClosing += frm_closing;
            }
            else
            {
             
                MessageBox.Show("Usuario o clave incorrecta", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
