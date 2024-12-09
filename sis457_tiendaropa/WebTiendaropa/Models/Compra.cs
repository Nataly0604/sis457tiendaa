using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public int IdProveedor { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public decimal MontoTotal { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
