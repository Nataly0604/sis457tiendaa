using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTiendaropa.Models;

namespace WebTiendaropa.Controllers
{
	[Authorize]
	public class ClientesController : Controller
	{
		private readonly FinalTiendaropaContext _context;

		public ClientesController(FinalTiendaropaContext context)
		{
			_context = context;
		}

		// GET: Clientes
		public async Task<IActionResult> Index()
		{
			return View(await _context.Clientes.Where(x => x.Estado != -1).ToListAsync());
		}

		// GET: Clientes/Buscar
		public IActionResult Buscar(string searchTerm)
		{
			// Realizar la búsqueda en base al término ingresado
			var clientes = _context.Clientes
				.Where(c => (c.NombreCompleto.Contains(searchTerm) || c.Documento.Contains(searchTerm)) && c.Estado != -1)
				.ToList();

			return View(clientes);  // Retornar la vista con los clientes encontrados
		}

		// GET: Clientes/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
			if (cliente == null)
			{
				return NotFound();
			}

			return View(cliente);
		}

		// GET: Clientes/Create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Documento,NombreCompleto,Email,Telefono")] Cliente cliente)
		{
			if (!string.IsNullOrEmpty(cliente.Documento) && !string.IsNullOrEmpty(cliente.NombreCompleto) &&
				!string.IsNullOrEmpty(cliente.Email) && !string.IsNullOrEmpty(cliente.Telefono))
			{
				// Verificar si ya existe un cliente con el mismo Documento
				bool documentoExiste = await _context.Clientes.AnyAsync(c => c.Documento == cliente.Documento);
				if (documentoExiste)
				{
					ModelState.AddModelError("Documento", "Ya existe un cliente con este documento.");
					return View(cliente);
				}

				// Verificar si ya existe un cliente con el mismo NombreCompleto
				bool nombreExiste = await _context.Clientes.AnyAsync(c => c.NombreCompleto == cliente.NombreCompleto);
				if (nombreExiste)
				{
					ModelState.AddModelError("NombreCompleto", "Ya existe un cliente con este nombre completo.");
					return View(cliente);
				}

				// Si no hay conflictos, proceder a crear el cliente
				cliente.UsuarioRegistro = User.Identity.Name;
				cliente.FechaRegistro = DateTime.Now;
				cliente.Estado = 1;
				_context.Add(cliente);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(cliente);
		}

		// GET: Clientes/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var cliente = await _context.Clientes.FindAsync(id);
			if (cliente == null)
			{
				return NotFound();
			}
			return View(cliente);
		}

		// POST: Clientes/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Documento,NombreCompleto,Email,Telefono,Estado")] Cliente cliente)
		{
			if (id != cliente.Id)
			{
				return NotFound();
			}

			// Validar que el Teléfono no esté vacío
			if (string.IsNullOrEmpty(cliente.Telefono))
			{
				ModelState.AddModelError("Telefono", "El campo Teléfono es obligatorio.");
				return View(cliente);
			}

			// Validar que el Email no esté vacío
			if (string.IsNullOrEmpty(cliente.Email))
			{
				ModelState.AddModelError("Email", "El campo Email es obligatorio.");
				return View(cliente);
			}

			// Validación de Documento
			if (!string.IsNullOrEmpty(cliente.Documento) && !string.IsNullOrEmpty(cliente.NombreCompleto))
			{
				bool documentoExiste = await _context.Clientes
					.AnyAsync(c => c.Documento == cliente.Documento && c.Id != cliente.Id);

				if (documentoExiste)
				{
					ModelState.AddModelError("Documento", "Ya existe otro cliente con este documento.");
					return View(cliente);
				}

				// Validación de Nombre Completo
				bool nombreExiste = await _context.Clientes
					.AnyAsync(c => c.NombreCompleto == cliente.NombreCompleto && c.Id != cliente.Id);

				if (nombreExiste)
				{
					ModelState.AddModelError("NombreCompleto", "Ya existe otro cliente con este nombre completo.");
					return View(cliente);
				}

				try
				{
					// Recuperar los valores actuales de UsuarioRegistro y FechaRegistro
					var clienteActual = await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
					if (clienteActual == null)
					{
						return NotFound();
					}

					// Mantener los valores originales de UsuarioRegistro y FechaRegistro
					cliente.UsuarioRegistro = clienteActual.UsuarioRegistro;
					cliente.FechaRegistro = clienteActual.FechaRegistro;

					_context.Update(cliente);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ClienteExists(cliente.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}

				return RedirectToAction(nameof(Index));
			}

			return View(cliente);
		}

		// GET: Clientes/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
			if (cliente == null)
			{
				return NotFound();
			}

			return View(cliente);
		}

		// POST: Clientes/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var cliente = await _context.Clientes.FindAsync(id);
			if (cliente != null)
			{
				_context.Clientes.Remove(cliente);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool ClienteExists(int id)
		{
			return _context.Clientes.Any(e => e.Id == id);
		}
	}
}