using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CadTiendaropa;
using System.Data.Entity;

namespace ClnTiendaropa
{
    public class UsuarioCln
    {
        public List<Usuario> listar()
        {
           
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    // quiero concatenar la tabla usuario con la tabla rol que me tarida los datos de las dos tablas juntas osea un inner join 

                    var resultado = db.Usuario
                                  .Include(u => u.Rol) // Incluir la relación con Rol
                                  .Select(u => new
                                  {
                                      u.id,
                                      u.usuario1,
                                      u.clave,
                                      u.idRol,
                                      u.estado,
                                      RolDescripcion = u.Rol.descripcion
                                  })
                                  .ToList();
                    return resultado.Select(item => new Usuario
                    {
                        id = item.id,
                        usuario1 = item.usuario1,
                        clave = item.clave,
                        idRol = item.idRol,

                        estado = item.estado,
                        Rol = new Rol { descripcion = item.RolDescripcion }
                    }).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           

        }


        public static Usuario obtenertodo()

        {
            return new Usuario();

        }
        // Labsis457tiendaderopaEntities1    

        // Método para validar el inicio de sesión de un usuario
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                return context.Usuario
                    .Where(x => x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }

   
        public Usuario obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Usuario
                         .Include(u => u.Rol) 
                         .Where(u => u.id == id)
                         .FirstOrDefault();
            }
        }


        public void crear(Usuario usuario)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    // Asignar valores adicionales si no vienen del formulario
                    usuario.usuarioRegistro = "empleado"; // o el valor adecuado
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.estado = 1; // Puedes ajustar el estado según sea necesario

                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el usuario", ex);
                }
            }
        }

        public void actualizar(Usuario usuario)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var usuarioExistente = db.Usuario.Find(usuario.id);
                    if (usuarioExistente != null)
                    {
                        // Actualizar solo las propiedades que se modifican
                        usuarioExistente.usuario1 = usuario.usuario1;
                        usuarioExistente.clave = usuario.clave;
                        usuarioExistente.estado = usuario.estado;
                        usuarioExistente.idRol = usuario.idRol;

                        // Asegurarse de que usuarioRegistro y fechaRegistro se mantengan sin cambios

                        db.Entry(usuarioExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Usuario no encontrado para actualizar");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario", ex);
                }
            }
        }



        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var usuario = db.Usuario.Find(id);
                if (usuario != null)
                {
                    db.Usuario.Remove(usuario);
                    db.SaveChanges();
                }
            }
        }

   
        public List<Usuario> buscarPorNombre(string nombreUsuario)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Usuario
                         .Include(u => u.Rol)
                         .Where(u => u.usuario1.Contains(nombreUsuario))
                         .ToList();
            }
        }
    }
}
    