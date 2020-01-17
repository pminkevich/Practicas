using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NoticiasAPI.Modelo
{
    public class NoticiasDBContext:DbContext
    {
        public NoticiasDBContext(DbContextOptions Opciones):base(Opciones)
        {

        }

        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(ModelBuilder MB)
        {
            new Noticia.Mapeo(MB.Entity<Noticia>());
            new Autor.Mapeo(MB.Entity<Autor>());
        }

       
    }
}
