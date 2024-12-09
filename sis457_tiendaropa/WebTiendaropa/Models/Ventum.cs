using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string DocumentoCliente { get; set; } = null!;

    public string NombreCliente { get; set; } = null!;

    public decimal MontoPago { get; set; }

    public decimal MontoCambio { get; set; }

    public decimal MontoTotal { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
}
