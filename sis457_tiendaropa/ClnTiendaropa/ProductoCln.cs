using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class ProductoCln
    {
        /// <summary>
        /// Lista todos los productos activos.
        /// </summary>
        /// <returns>Lista de productos</returns>
        public List<Producto> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Producto
                             .Where(p => p.estado == 1) // Solo productos activos
                             .Include(p => p.Categoria) // Incluir información de la categoría
                             .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar productos: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Obtiene un producto específico por su ID.
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <returns>Objeto de tipo Producto</returns>
        public Producto obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Producto.Find(id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el producto: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Crea un nuevo producto.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto</param>
        public void crear(Producto producto)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    db.Producto.Add(producto);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el producto: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Actualiza un producto existente.
        /// </summary>
        /// <param name="producto">Objeto de tipo Producto</param>
        public void actualizar(Producto producto)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var productoExistente = db.Producto.Find(producto.id);
                    if (productoExistente != null)
                    {
                        productoExistente.nombre = producto.nombre;
                        productoExistente.descripcion = producto.descripcion;
                        productoExistente.stock = producto.stock;
                        productoExistente.precioVenta = producto.precioVenta;
                        productoExistente.estado = producto.estado;
                        productoExistente.idCategoria = producto.idCategoria;

                        db.Entry(productoExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Producto no encontrado para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el producto: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Elimina lógicamente un producto por su ID.
        /// </summary>
        /// <param name="id">ID del producto</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var producto = db.Producto.Find(id);
                if (producto != null)
                {
                    db.Producto.Remove(producto);
                    db.SaveChanges();
                }
            }
        }
    }
}
