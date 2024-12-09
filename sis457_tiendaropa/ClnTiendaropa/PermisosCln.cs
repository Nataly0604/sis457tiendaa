using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadTiendaropa;


namespace ClnTiendaropa
{
    public class PermisosCln
    {
        public List<Permiso> listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    lista = db.Permiso.Where(x => x.Rol.Usuario.Any(u => u.id == idusuario)).ToList(); // esto retorna una lista de permisos de un usuario 
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return lista;
            }
        }
    }
}
