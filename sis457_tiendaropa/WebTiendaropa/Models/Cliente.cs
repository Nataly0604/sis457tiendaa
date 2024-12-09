using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebTiendaropa.Models
{
	public partial class Cliente
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "El documento es obligatorio.")]
		public string Documento { get; set; } = null!;

		[Required(ErrorMessage = "El nombre completo es obligatorio.")]
		public string NombreCompleto { get; set; } = null!;

		[Required(ErrorMessage = "El email es obligatorio.")]
		public string Email { get; set; } = null!;

		[Required(ErrorMessage = "El teléfono es obligatorio.")]
		public string Telefono { get; set; } = null!;

		public string UsuarioRegistro { get; set; } = null!;

		public DateTime FechaRegistro { get; set; }

		public short Estado { get; set; }
	}
}