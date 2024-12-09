using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class ProveedorCln
    {
        /// <summary>
        /// Lista todos los proveedores activos.
        /// </summary>
        /// <returns>Lista de proveedores</returns>
        public List<Proveedor> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Proveedor
                             .Where(p => p.estado == 1) // Solo proveedores activos
                             .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar proveedores: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Obtiene un proveedor específico por su ID.
        /// </summary>
        /// <param name="id">ID del proveedor</param>
        /// <returns>Objeto de tipo Proveedor</returns>
        public Proveedor obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Proveedor.Find(id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el proveedor: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Crea un nuevo proveedor.
        /// </summary>
        /// <param name="proveedor">Objeto de tipo Proveedor</param>
        public void crear(Proveedor proveedor)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    db.Proveedor.Add(proveedor);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el proveedor: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Actualiza un proveedor existente.
        /// </summary>
        /// <param name="proveedor">Objeto de tipo Proveedor</param>
        public void actualizar(Proveedor proveedor)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var proveedorExistente = db.Proveedor.Find(proveedor.id);
                    if (proveedorExistente != null)
                    {
                        proveedorExistente.documento = proveedor.documento;
                        proveedorExistente.razonSocial = proveedor.razonSocial;
                        proveedorExistente.email = proveedor.email;
                        proveedorExistente.telefono = proveedor.telefono;
                        proveedorExistente.estado = proveedor.estado;

                        db.Entry(proveedorExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Proveedor no encontrado para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el proveedor: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Elimina lógicamente un proveedor por su ID.
        /// </summary>
        /// <param name="id">ID del proveedor</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var proveedorExistente = db.Proveedor.Find(id);
                    if (proveedorExistente != null)
                    {
                        proveedorExistente.estado = 0; // Cambiamos el estado a inactivo
                        db.Entry(proveedorExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Proveedor no encontrado para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el proveedor: " + ex.Message, ex);
                }
            }
        }
    }
}