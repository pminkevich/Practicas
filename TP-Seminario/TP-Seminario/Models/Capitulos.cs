using System;
using System.Collections.Generic;

namespace TP_Seminario.Models
{
    public partial class Capitulos
    {
        public int Id { get; set; }
        public int Idserie { get; set; }
        public int Capitulo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }

        public virtual Listseries Listseries { get; set; }
    }
}
