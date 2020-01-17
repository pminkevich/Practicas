using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticiasAPI.Modelo;
using NoticiasAPI.Services;

namespace NoticiasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        private readonly NoticiaService _noticiaService;
        public NoticiasController(NoticiaService NoticiaService)
        {
            _noticiaService = NoticiaService;
        }

        [HttpGet]
        [Route("GetNews")]
        public IActionResult GetNews()
        {
            return Ok(_noticiaService.GetNews());
        }

        [HttpPost]
        [Route("AddNews")]
        public IActionResult AddNews([FromBody]Noticia noticia)
        {
            var result = _noticiaService.AddNews(noticia);
            if (result)
            {
                return Ok("Exito");
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPut]
        [Route("EditNews")]
        public IActionResult EditNews([FromBody] Noticia noticia)
        {
            var result = _noticiaService.EditNews(noticia);
            if (result)
            {
                return Ok("Exito");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DelNews/{NoticiaID}")]
        public IActionResult DelNews(int NoticiaID)
        {
            var result = _noticiaService.DelNews(NoticiaID);
            if (result)
            {
                return Ok("Exito");
            }
            else
            {
                return BadRequest();
            }
        }


    }
}