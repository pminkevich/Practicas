using System;
using System.Collections.Generic;

namespace TP_Seminario.Models
{
    public partial class Tiposerie
    {
        public Tiposerie()
        {
            Listseries = new HashSet<Listseries>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Listseries> Listseries { get; set; }
    }
}
