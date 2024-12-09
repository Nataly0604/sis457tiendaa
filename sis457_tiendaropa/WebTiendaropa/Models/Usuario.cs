using System;
using System.Collections.Generic;

namespace WebTiendaropa.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int IdEmpleado { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
}
