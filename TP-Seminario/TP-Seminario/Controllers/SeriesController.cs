using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_Seminario.Models;

namespace TP_Seminario.Controllers
{
    public class SeriesController : Controller
    {
        private readonly seriesContext _context;

        public SeriesController(seriesContext context)
        {
            _context = context;
        }

        // GET: Capitulos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Listseries.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listseries = await _context.Listseries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listseries == null)
            {
                return NotFound();
            }

            return View(listseries);
        }

        // GET: Tiposeries/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.listaSeries = await _context.Tiposerie.ToListAsync();
            return View();
        }

        // POST: Tiposeries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tapa,Nombre,Descripcion,Idtipo,Vistas,Puntos")] Listseries listseries)
        {
            if (ModelState.IsValid)
            {
                listseries.Puntos = 0;
                listseries.Vistas = 0;

                _context.Add(listseries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listseries);
        }

        // GET: Tiposeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.listaSeries = await _context.Tiposerie.ToListAsync();
            var listseries = await _context.Listseries.FindAsync(id);
            if (listseries == null)
            {
                return NotFound();
            }
            return View(listseries);
        }

        // POST: Tiposeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Tapa, Nombre, Descripcion, Idtipo, Vistas, Puntos")] Listseries listseries)
        {
            if (id != listseries.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listseries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListseriesExists(listseries.Id))
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
            ViewBag.listaSeries = await _context.Tiposerie.ToListAsync();
            return View(listseries);
        }

        // GET: Tiposeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listseries = await _context.Listseries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listseries == null)
                return NotFound();
            

            return View(listseries);
        }

        // POST: Tiposeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listseries = await _context.Listseries.FindAsync(id);
            _context.Listseries.Remove(listseries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListseriesExists(int id)
        {
            return _context.Listseries.Any(e => e.Id == id);
        }

    }
}