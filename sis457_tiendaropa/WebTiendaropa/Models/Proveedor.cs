using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string Documento { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
