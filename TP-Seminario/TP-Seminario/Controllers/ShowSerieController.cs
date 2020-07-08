using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP_Seminario.Models;

namespace TP_Seminario.Controllers
{
    public class ShowSerieController : Controller
    {
        private readonly seriesContext _context;

        public ShowSerieController(seriesContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/mas-vista")]
        public async Task<IActionResult> masVista()
        {
           
                var result = await _context.Listseries.OrderBy(x => x.Vistas).FirstOrDefaultAsync();
                ViewBag.titulo = "Mas Vista";
                return View("Index", result);
            
        }

        [HttpGet]
        [Route("/mas-votada")]
        public async Task<IActionResult> masVotada()
        {
            
                var result = await _context.Listseries.OrderBy(x => x.Puntos).FirstOrDefaultAsync();
            ViewBag.titulo = "Mas Votada";
                return View("Index", result);
            
        }
        [HttpPost]
        public async Task<IActionResult> Index(string busqueda)
        {
            var result = await _context.Listseries.Where(x => x.Nombre.Contains(busqueda)).FirstOrDefaultAsync();
            
            return View(result);
        }
    }
}