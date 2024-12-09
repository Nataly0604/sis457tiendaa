using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa

    {
        public class VentaCln
        {
            // Método para obtener todas las ventas
            public static List<Venta> GetAll()
            {
                using (var context = new Labsis457tiendaderopaEntities())
                {
                    return context.Venta.ToList();
                }
            }

            // Método para obtener una venta por ID
            public static Venta GetById(int id)
            {
                using (var context = new Labsis457tiendaderopaEntities())
                {
                    return context.Venta.FirstOrDefault(v => v.id == id);
                }
            }

            // Método para insertar una nueva venta
            public static void Insert(Venta venta)
            {
                using (var context = new Labsis457tiendaderopaEntities())
                {
                    context.Venta.Add(venta);
                    context.SaveChanges();
                }
            }

            // Método para actualizar una venta existente
            public static void Update(Venta venta)
            {
                using (var context = new Labsis457tiendaderopaEntities())
                {
                    var existingVenta = context.Venta.FirstOrDefault(v => v.id == venta.id);
                    if (existingVenta != null)
                    {
                        existingVenta.idUsuario = venta.idUsuario;
                        existingVenta.tipoDocumento = venta.tipoDocumento;
                        existingVenta.numeroDocumento = venta.numeroDocumento;
                        existingVenta.documentoCliente = venta.documentoCliente;
                        existingVenta.nombreCliente = venta.nombreCliente;
                        existingVenta.montoPago = venta.montoPago;
                        existingVenta.montoCambio = venta.montoCambio;
                        existingVenta.montoTotal = venta.montoTotal;
                        existingVenta.usuarioRegistro = venta.usuarioRegistro;
                        existingVenta.fechaRegistro = venta.fechaRegistro;
                        existingVenta.estado = venta.estado;

                        context.SaveChanges();
                    }
                }
            }

            // Método para eliminar una venta (cambia el estado a inactivo)
            public static void Delete(int id)
            {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var Ventas = db.Venta.Find(id);
                if (Ventas != null)
                {
                    db.Venta.Remove(Ventas);
                    db.SaveChanges();
                }
            }
        }
        }
    }
