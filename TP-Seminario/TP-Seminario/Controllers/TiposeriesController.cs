using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_Seminario.Models;

namespace TP_Seminario.Controllers
{
    public class TiposeriesController : Controller
    {
        private readonly seriesContext _context;

        public TiposeriesController(seriesContext context)
        {
            _context = context;
        }

        // GET: Tiposeries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tiposerie.ToListAsync());
        }

        // GET: Tiposeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposerie = await _context.Tiposerie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposerie == null)
            {
                return NotFound();
            }

            return View(tiposerie);
        }

        // GET: Tiposeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tiposeries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo")] Tiposerie tiposerie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposerie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposerie);
        }

        // GET: Tiposeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposerie = await _context.Tiposerie.FindAsync(id);
            if (tiposerie == null)
            {
                return NotFound();
            }
            return View(tiposerie);
        }

        // POST: Tiposeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo")] Tiposerie tiposerie)
        {
            if (id != tiposerie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposerie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposerieExists(tiposerie.Id))
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
            return View(tiposerie);
        }

        // GET: Tiposeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposerie = await _context.Tiposerie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposerie == null)
            {
                return NotFound();
            }

            return View(tiposerie);
        }

        // POST: Tiposeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiposerie = await _context.Tiposerie.FindAsync(id);
            _context.Tiposerie.Remove(tiposerie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposerieExists(int id)
        {
            return _context.Tiposerie.Any(e => e.Id == id);
        }
    }
}
