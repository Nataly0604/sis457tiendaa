using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadTiendaropa;

namespace ClnTiendaropa
{
    public class RoleCln
    {
        public List<Rol> listar()
        {
            List<Rol> datos = new List<Rol>();
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    datos = db.Rol.ToList();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return datos;
            }

        }
    }
}

