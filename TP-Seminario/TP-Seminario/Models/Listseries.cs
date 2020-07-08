using System;
using System.Collections.Generic;

namespace TP_Seminario.Models
{
    public partial class Listseries
    {
        public Listseries()
        {
            Capitulos = new HashSet<Capitulos>();
        }

        public int Id { get; set; }
        public string Tapa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idtipo { get; set; }
        public int Vistas { get; set; }
        public int Puntos { get; set; }

        public virtual Tiposerie Tiposerie { get; set; }
        public virtual ICollection<Capitulos> Capitulos { get; set; }
    }
}
