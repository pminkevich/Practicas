using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;


        public int Dato
        {
            set
            {
                dato = value;
            }
            get
            {
                return dato;
            }
        }
        public Nodo Siguiente
        {
            set
            {
                siguiente = value;
            }
            get
            {
                return siguiente;
            }
        }
    }
}
