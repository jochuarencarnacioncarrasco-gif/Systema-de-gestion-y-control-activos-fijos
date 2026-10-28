using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using Systema_de_gestion_y_control_activos_fijos.Models;

namespace Systema_de_gestion_y_control_activos_fijos.Controllers
{
    public class ActivosController : Controller
    {
        private readonly AppDBContext _context;

        public ActivosController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Activos/Index
        public async Task<IActionResult> Index()
        {
            var activos = await _context.ActivoFijo
                .Include(a => a.Categoria)
                .Include(a => a.Ubicacion)
                .Include(a => a.EstadoActivo)
                .Include(a => a.Proveedor)
                .ToListAsync();
            return View(activos);
        }

        // GET: Activos/Create
        public IActionResult Create()
        {
            CargarListasSelect();
            return View();
        }

        // POST: Activos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ActivoEntity activo)
        {
            // Omitimos validaciones de navegación de Entity Framework en las propiedades de objeto
            ModelState.Remove("Categoria");
            ModelState.Remove("Ubicacion");
            ModelState.Remove("EstadoActivo");
            ModelState.Remove("Proveedor");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(activo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    // Captura el error de índice único y muestra un mensaje amigable en el campo
                    ModelState.AddModelError("CodigoInventario", "Este código de inventario ya está registrado en otro activo. Por favor, ingrese uno diferente.");
                }
            }

            // Si falla algo (por validación o por el try-catch), recargamos los dropdowns manteniendo la selección previa
            CargarListasSelect(activo);
            return View(activo);
        }

        // Método auxiliar para poblar los desplegables (Dropdowns)
        private void CargarListasSelect(ActivoEntity activo = null)
        {
            ViewBag.CategoriaId = new SelectList(_context.Set<CategoriaActivoEntity>(), "Id", "Nombre", activo?.CategoriaId);
            ViewBag.UbicacionId = new SelectList(_context.Set<Ubicacione>(), "Id", "Nombre", activo?.UbicacionId);
            ViewBag.EstadoId = new SelectList(_context.Set<EstadoActivo>(), "Id", "Nombre", activo?.EstadoId);
            ViewBag.ProveedorId = new SelectList(_context.Set<ProveedorEntity>(), "Id", "Nombre", activo?.ProveedorId);
        }
    }
}