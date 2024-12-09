using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class CompraCln
    {
        /// <summary>
        /// Lista todas las compras activas.
        /// </summary>
        /// <returns>Lista de compras</returns>
        public List<Compra> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Compra
                         .Include(c => c.Usuario)
                         .Include(c => c.Proveedor)
                         .Where(c => c.estado == 1)
                         .ToList();
            }
        }

        /// <summary>
        /// Obtiene una compra específica por su ID.
        /// </summary>
        /// <param name="id">ID de la compra</param>
        /// <returns>Objeto de tipo Compra</returns>
        public Compra obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Compra
                         .Include(c => c.Usuario)
                         .Include(c => c.Proveedor)
                         .FirstOrDefault(c => c.id == id);
            }
        }

        /// <summary>
        /// Crea una nueva compra.
        /// </summary>
        /// <param name="compra">Objeto de tipo Compra</param>
        public void crear(Compra compra)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    db.Compra.Add(compra);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el proveedor: " + ex.Message, ex);
                }
            }
        }


        /// <summary>
        /// Actualiza una compra existente.
        /// </summary>
        /// <param name="compra">Objeto de tipo Compra</param>
        public void actualizar(Compra compra)
        {

            using (var db = new Labsis457tiendaderopaEntities())
            {
                var compraExistente = db.Compra.Find(compra.id);
                if (compraExistente != null)
                {
                    compraExistente.idUsuario = compra.idUsuario;
                    compraExistente.idProveedor = compra.idProveedor;
                    compraExistente.tipoDocumento = compra.tipoDocumento;
                    compraExistente.numeroDocumento = compra.numeroDocumento;
                    compraExistente.montoTotal = compra.montoTotal;
                    compraExistente.usuarioRegistro = compra.usuarioRegistro;
                    compraExistente.fechaRegistro = compra.fechaRegistro;
                    compraExistente.estado = compra.estado;

                    db.Entry(compraExistente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Compra no encontrada para actualizar.");
                }
            }
        }

            /// <summary>
            /// Elimina lógicamente una compra por su ID.
            /// </summary>
            /// <param name="id">ID de la compra</param>
            public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var compraExistente = db.Compra.Find(id);
                if (compraExistente != null)
                {
                    compraExistente.estado = 0; // Marcamos como inactivo
                    db.Entry(compraExistente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Compra no encontrada para eliminar.");
                }
            }
        }
    }
}