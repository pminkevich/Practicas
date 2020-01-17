using Microsoft.EntityFrameworkCore;
using NoticiasAPI.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NoticiasAPI.Services
{
    public class NoticiaService
    {
        private readonly  NoticiasDBContext _noticiasDBContext ;
        public NoticiaService(NoticiasDBContext NoticiaDBContext)
        {
            _noticiasDBContext = NoticiaDBContext;
        }

        public List<Noticia> GetNews()
        {
            var result = _noticiasDBContext.Noticia.Include(x => x.Autor).ToList();
                   
                return result;
            
        }
        public bool AddNews(Noticia Noticia)
        {
            try
            {
                _noticiasDBContext.Add(Noticia);
                _noticiasDBContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                return false;

            }
        }

        public bool EditNews(Noticia Noticia)
        {
            try
            {
                var result = _noticiasDBContext.Noticia.Where(x => x.NoticiaID == Noticia.NoticiaID).FirstOrDefault();
                if (result != null)
                {
                    result.Titulo = Noticia.Titulo;
                    result.Descripcion = Noticia.Descripcion;
                    result.Contenido = Noticia.Contenido;
                    result.Fecha = Noticia.Fecha;
                    result.AutorID = Noticia.AutorID;

                    _noticiasDBContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool DelNews(int NoticiaID)
        {
            try
            {
                var result = _noticiasDBContext.Noticia.Where(x => x.NoticiaID == NoticiaID).FirstOrDefault();
                _noticiasDBContext.Remove(result);
                _noticiasDBContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
