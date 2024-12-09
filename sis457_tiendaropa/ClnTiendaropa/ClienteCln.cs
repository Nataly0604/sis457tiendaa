using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public  class ClienteCln
    {
        /// <summary>
        /// Lista todos los clientes activos.
        /// </summary>
        /// <returns>Lista de clientes activos</returns>
        public List<Cliente> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Cliente
                             .Where(c => c.estado == 1) // Solo clientes activos
                             .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar clientes: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Obtiene un cliente específico por su ID.
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>Objeto de tipo Cliente</returns>
        public Cliente obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    return db.Cliente.Find(id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el cliente: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Crea un nuevo cliente.
        /// </summary>
        /// <param name="cliente">Objeto de tipo Cliente</param>
        public void crear(Cliente cliente)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1; // Activo por defecto
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el cliente: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Actualiza un cliente existente.
        /// </summary>
        /// <param name="cliente">Objeto de tipo Cliente</param>
        public void actualizar(Cliente cliente)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var clienteExistente = db.Cliente.Find(cliente.id);
                    if (clienteExistente != null)
                    {
                        clienteExistente.documento = cliente.documento;
                        clienteExistente.nombreCompleto = cliente.nombreCompleto;
                        clienteExistente.email = cliente.email;
                        clienteExistente.telefono = cliente.telefono;
                        clienteExistente.direccion = cliente.direccion;
                        clienteExistente.estado = cliente.estado;

                        db.Entry(clienteExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Cliente no encontrado para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el cliente: " + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// Elimina lógicamente un cliente por su ID.
        /// </summary>
        /// <param name="id">ID del cliente</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    var clienteExistente = db.Cliente.Find(id);
                    if (clienteExistente != null)
                    {
                        clienteExistente.estado = 0; // Marcamos como inactivo
                        db.Entry(clienteExistente).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Cliente no encontrado para eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el cliente: " + ex.Message, ex);
                }
            }
        }
    }
}