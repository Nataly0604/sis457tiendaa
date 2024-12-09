using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{

    public class CategoriaCln
    {

        /// <summary>
        /// Lista todas las categorías activas.
        /// </summary>
        /// <returns>Lista de categorías</returns>
        public List<Categoria> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Categoria
                             .Where(c => c.estado == 1) // Solo categorías activas
                             .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar categorías: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Obtiene una categoría específica por su ID.
        /// </summary>
        /// <param name="id">ID de la categoría</param>
        /// <returns>Objeto de tipo Categoria</returns>
        public Categoria obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Categoria.Find(id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la categoría: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Crea una nueva categoría.
        /// </summary>
        /// <param name="categoria">Objeto de tipo Categoria</param>
        public void crear(Categoria categoria)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    db.Categoria.Add(categoria);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la categoría: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Actualiza una categoría existente.
        /// </summary>
        /// <param name="categoria">Objeto de tipo Categoria</param>
        public void actualizar(Categoria categoria)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var categoriaExistente = db.Categoria.Find(categoria.id);
                    if (categoriaExistente != null)
                    {
                        categoriaExistente.descripcion = categoria.descripcion;
                        categoriaExistente.estado = categoria.estado;

                        db.Entry(categoriaExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Categoría no encontrada para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la categoría: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Elimina lógicamente una categoría por su ID.
        /// </summary>
        /// <param name="id">ID de la categoría</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var categoria = db.Categoria.Find(id);
                if (categoria != null)
                {
                    db.Categoria.Remove(categoria);
                    db.SaveChanges();
                }
            }
        }
    }
}
