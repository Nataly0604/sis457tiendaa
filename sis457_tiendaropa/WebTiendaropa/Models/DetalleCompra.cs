using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class DetalleCompra
{
    public int Id { get; set; }

    public int IdCompra { get; set; }

    public int IdProducto { get; set; }

    public decimal? PrecioCompra { get; set; }

    public decimal? PrecioVenta { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Compra IdCompraNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
