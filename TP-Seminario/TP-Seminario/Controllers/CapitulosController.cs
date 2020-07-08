using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_Seminario.Models;

namespace TP_Seminario.Controllers
{
    public class CapitulosController : Controller
    {
        private readonly seriesContext _context;
        public CapitulosController(seriesContext context)
        {
            _context = context;
        }
        // GET: Capitulos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Capitulos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulos = await _context.Capitulos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (capitulos == null)
            {
                return NotFound();
            }

            return View(capitulos);
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
        public async Task<IActionResult> Create([Bind("Id,Idserie,Capitulo,Titulo,Descripcion,Url")] Capitulos capitulos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(capitulos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(capitulos);
        }

        // GET: Tiposeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulos = await _context.Capitulos.FindAsync(id);
            if (capitulos == null)
            {
                return NotFound();
            }
            return View(capitulos);
        }

        // POST: Tiposeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Idserie,Capitulo,Titulo,Descripcion,Url")] Capitulos capitulos)
        {
            if (id != capitulos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(capitulos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CapitulosExists(capitulos.Id))
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
            return View(capitulos);
        }

        // GET: Tiposeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var capitulos = await _context.Capitulos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (capitulos == null)
            {
                return NotFound();
            }

            return View(capitulos);
        }

        // POST: Tiposeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var capitulos = await _context.Capitulos.FindAsync(id);
            _context.Capitulos.Remove(capitulos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CapitulosExists(int id)
        {
            return _context.Capitulos.Any(e => e.Id == id);
        }
    }
}
