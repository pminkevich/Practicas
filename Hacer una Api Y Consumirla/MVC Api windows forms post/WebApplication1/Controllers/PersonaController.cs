﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(Models.Request.PersonaRequest model)
        {
            using (Models.pruebillaEntities db = new Models.pruebillaEntities())
            {
                var oPersona = new Models.persona();
                oPersona.nombre = model.Nombre;
                oPersona.edad = model.Edad;
                db.persona.Add(oPersona);
                db.SaveChanges();
            }

            return Ok("exito");
        }
    }
}
