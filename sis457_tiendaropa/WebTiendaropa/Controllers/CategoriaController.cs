using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTiendaropa.Models;

namespace WebBroasteria.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly FinalTiendaropaContext _context;

        public CategoriaController(FinalTiendaropaContext context)
        {
            _context = context;
        }

        // GET: Categoria
        public async Task<IActionResult> Index()
        {
            var categorias = await _context.Categoria
                .Where(c => c.Estado != -1) // Filtro por Estado
                .ToListAsync();

            return View(categorias);
        }

        // GET: Categoria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorium = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorium == null)
            {
                return NotFound();
            }

            return View(categorium);
        }

        // GET: Categoria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,UsuarioRegistro,FechaRegistro")] Categorium categorium)
        {
            if (!string.IsNullOrEmpty(categorium.Descripcion))
            {
                // Verifica si ya existe una categoría con la misma descripción
                bool exists = _context.Categoria.Any(c => c.Descripcion == categorium.Descripcion);

                if (exists)
                {
                    ModelState.AddModelError("Descripcion", "Ya existe una categoría con esta descripción.");
                    return View(categorium);
                }

                // Si no existe, crea la categoría
                categorium.UsuarioRegistro = User.Identity.Name;
                categorium.FechaRegistro = DateTime.Now;
                categorium.Estado = 1;

                _context.Add(categorium);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(categorium);
        }

        // GET: Categoria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorium = await _context.Categoria.FindAsync(id);
            if (categorium == null)
            {
                return NotFound();
            }
            return View(categorium);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,UsuarioRegistro,FechaRegistro,Estado")] Categorium categorium)
        {
            if (id != categorium.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Verificar si ya existe una categoría con la misma descripción, pero no la actual
                    bool categoryExists = await _context.Categoria
                        .AnyAsync(c => c.Descripcion == categorium.Descripcion && c.Id != categorium.Id);

                    if (categoryExists)
                    {
                        ModelState.AddModelError("", "Ya existe una categoría con esta descripción.");
                        return View(categorium);
                    }

                    // Si no existe una categoría con la misma descripción, actualizar los datos
                    _context.Update(categorium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriumExists(categorium.Id))
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
            return View(categorium);
        }

        // GET: Categoria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorium = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorium == null)
            {
                return NotFound();
            }

            return View(categorium);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categorium = await _context.Categoria.FindAsync(id);
            if (categorium != null)
            {
                _context.Categoria.Remove(categorium);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriumExists(int id)
        {
            return _context.Categoria.Any(e => e.Id == id);
        }
    }
}
