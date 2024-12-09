using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTiendaropa.Models;

public partial class Categorium
{
    public int Id { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    [StringLength(100, ErrorMessage = "La descripción no puede superar los 100 caracteres.")]
    public string Descripcion { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}