using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinClass
{
    public class Nodo
    {
        private char dato;
        private Nodo siguiente;

        public char Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
