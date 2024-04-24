using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AndradeLeonardo_ExamenProgreso1.Data;
using AndradeLeonardo_ExamenProgreso1.Models;

namespace AndradeLeonardo_ExamenProgreso1.Controllers
{
    public class DatossesController : Controller
    {
        private readonly AndradeLeonardo_ExamenProgreso1Context _context;

        public DatossesController(AndradeLeonardo_ExamenProgreso1Context context)
        {
            _context = context;
        }

        // GET: Datosses
        public async Task<IActionResult> Index()
        {
            return View(await _context.datosses.ToListAsync());
        }

        // GET: Datosses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoss = await _context.datosses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoss == null)
            {
                return NotFound();
            }

            return View(datoss);
        }

        // GET: Datosses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Datosses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,sueldo,Pregunta,Fecha")] Datoss datoss)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datoss);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datoss);
        }

        // GET: Datosses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoss = await _context.datosses.FindAsync(id);
            if (datoss == null)
            {
                return NotFound();
            }
            return View(datoss);
        }

        // POST: Datosses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,sueldo,Pregunta,Fecha")] Datoss datoss)
        {
            if (id != datoss.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datoss);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatossExists(datoss.Id))
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
            return View(datoss);
        }

        // GET: Datosses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datoss = await _context.datosses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (datoss == null)
            {
                return NotFound();
            }

            return View(datoss);
        }

        // POST: Datosses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datoss = await _context.datosses.FindAsync(id);
            if (datoss != null)
            {
                _context.datosses.Remove(datoss);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatossExists(int id)
        {
            return _context.datosses.Any(e => e.Id == id);
        }
    }
}
