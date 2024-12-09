using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class DetalleCln
    {
        /// <summary>
        /// Lists all active detail records for purchases.
        /// </summary>
        /// <returns>List of purchase details</returns>
        public List<DetalleCompra> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.DetalleCompra
                         .Include(d => d.Compra)
                         .Include(d => d.Producto)
                         .Where(d => d.estado == 1)
                         .ToList();
            }
        }

        /// <summary>
        /// Gets a specific purchase detail by its ID.
        /// </summary>
        /// <param name="id">ID of the purchase detail</param>
        /// <returns>DetalleCompra object</returns>
        public DetalleCompra obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.DetalleCompra
                         .Include(d => d.Compra)
                         .Include(d => d.Producto)
                         .FirstOrDefault(d => d.id == id);
            }
        }

        /// <summary>
        /// Creates a new purchase detail.
        /// </summary>
        /// <param name="detalle">DetalleCompra object</param>
        public void crear(DetalleCompra detalle)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                db.DetalleCompra.Add(detalle);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing purchase detail.
        /// </summary>
        /// <param name="detalle">DetalleCompra object with updated data</param>
        public void actualizar(DetalleCompra detalle)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var detalleExistente = db.DetalleCompra.Find(detalle.id);
                if (detalleExistente != null)
                {
                    detalleExistente.precioCompra = detalle.precioCompra;
                    detalleExistente.cantidad = detalle.cantidad;
                    detalleExistente.total = detalle.total;
                    detalleExistente.estado = detalle.estado;
                    detalleExistente.usuarioRegistro = detalle.usuarioRegistro;

                    db.Entry(detalleExistente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Detalle de compra no encontrado para actualizar.");
                }
            }
        }

        /// <summary>
        /// Logically deletes a purchase detail by setting its status to inactive.
        /// </summary>
        /// <param name="id">ID of the purchase detail</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var detalleExistente = db.DetalleCompra.Find(id);
                if (detalleExistente != null)
                {
                    detalleExistente.estado = 0; // Set to inactive
                    db.Entry(detalleExistente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Detalle de compra no encontrado para eliminar.");
                }
            }
        }
    }
}
