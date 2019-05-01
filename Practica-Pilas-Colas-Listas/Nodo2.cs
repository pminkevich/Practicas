using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Nodo2
    {
        private int dato;
        private Nodo2 siguiente;
        private Nodo2 anterior;


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
        public Nodo2 Siguiente
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
        public Nodo2 Anterior
        {
            set
            {
                anterior = value;
            }
            get
            {
                return anterior;
            }
        }

    }
}
