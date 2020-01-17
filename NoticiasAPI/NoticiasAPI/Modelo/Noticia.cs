﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Modelo
{
    public class Noticia
    {
        public int NoticiaID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int AutorID { get; set; }
        public Autor Autor { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Noticia> mapeoNoticia)
            {
                mapeoNoticia.HasKey(x => x.NoticiaID);
                //mapeoNoticia.Property(x => x.Titulo).HasColumnName("Otro NOmbre");
                // mapeoNoticia.ToTable("Otro Nombre de Table");
                mapeoNoticia.HasOne(x => x.Autor);

            }
        }
    }

   
}
