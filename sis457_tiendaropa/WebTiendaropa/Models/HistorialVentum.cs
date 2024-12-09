using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class HistorialVentum
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public decimal PrecioVenta { get; set; }

    public int Cantidad { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
