using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class DetalleVentaCln
    {
        // Método para obtener todos los detalles de venta
        public static List<DetalleVenta> GetAll()
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                return context.DetalleVenta.ToList();
            }
        }

        // Método para obtener detalles de venta por ID de la venta
        public static List<DetalleVenta> GetByVentaId(int idVenta)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                return context.DetalleVenta.Where(d => d.idVenta == idVenta).ToList();
            }
        }

        // Método para obtener un detalle de venta por su ID
        public static DetalleVenta GetById(int id)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                return context.DetalleVenta.FirstOrDefault(d => d.id == id);
            }
        }

        // Método para insertar un nuevo detalle de venta
        public static void Insert(DetalleVenta detalleVenta)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                context.DetalleVenta.Add(detalleVenta);
                context.SaveChanges();
            }
        }

        // Método para actualizar un detalle de venta existente
        public static void Update(DetalleVenta detalleVenta)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                var existingDetalle = context.DetalleVenta.FirstOrDefault(d => d.id == detalleVenta.id);
                if (existingDetalle != null)
                {
                    existingDetalle.idVenta = detalleVenta.idVenta;
                    existingDetalle.idProducto = detalleVenta.idProducto;
                    existingDetalle.precioVenta = detalleVenta.precioVenta;
                    existingDetalle.cantidad = detalleVenta.cantidad;
                    existingDetalle.subTotal = detalleVenta.subTotal;
                    existingDetalle.usuarioRegistro = detalleVenta.usuarioRegistro;
                    existingDetalle.fechaRegistro = detalleVenta.fechaRegistro;
                    existingDetalle.estado = detalleVenta.estado;

                    context.SaveChanges();
                }
            }
        }

        // Método para eliminar un detalle de venta (cambia el estado a inactivo)
        public static void Delete(int id)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                var detalleVenta = context.DetalleVenta.FirstOrDefault(d => d.id == id);
                if (detalleVenta != null)
                {
                    detalleVenta.estado = 0; // 0 representa estado inactivo
                    context.SaveChanges();
                }
            }
        }
    }
}