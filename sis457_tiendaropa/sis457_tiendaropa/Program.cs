using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClnTiendaropa;
using System.Data.SqlClient;
using CadTiendaropa;

using System.Data.Entity;

namespace sis457_tiendaropa
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //string mensaje;
            //using (var context = new Labsis457tiendaderopaEntities())
            //{
            //    try
            //    {
            //        // Realiza una consulta simple para verificar la conexión
            //        var usuarios = context.Usuario.Take(1).ToList();

            //        if (usuarios.Any())
            //        {
            //            mensaje = "Conexión exitosa. Se encontró al menos un usuario en la base de datos.";
            //        }
            //        else
            //        {
            //            mensaje = "Conexión exitosa, pero no se encontraron registros en la tabla Usuario.";
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        mensaje = "Error de conexión: " + ex.Message;
            //    }
            //}

            //// Muestra el mensaje en un MessageBox
            //MessageBox.Show(mensaje, "Resultado de la Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Habilita los estilos visuales y ejecuta el formulario de autenticación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autentication());
        }
    }
}
