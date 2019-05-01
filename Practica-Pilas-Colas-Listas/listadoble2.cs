using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class listadoble2
    {
        private Nodo2 Primero, Ultimo;

        public listadoble2()
        {
            Primero = null;
            Ultimo = null;

        }

        public void InsertarNodo(int x)
        {
            Nodo2 nuevo = new Nodo2();
            nuevo.Dato = x;

            if (Primero == null)
            {
                nuevo.Siguiente = null;
                nuevo.Anterior = null;
                Primero = nuevo;
                Ultimo = nuevo;
                
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Anterior = Ultimo;
                Ultimo = nuevo;
                Ultimo.Siguiente = null;
            }
        }
        public void EliminarNodo(int x)
        {
            Nodo2 Actual = Primero;
            Nodo2 Anterior = null;
            while (Actual != null)
            {
                if (Actual.Dato == x)
                {
                    if (Actual == Primero)
                    {
                        Primero = Primero.Siguiente;
                    }
                    else if (Actual == Ultimo)
                    {
                        Anterior.Siguiente = null;
                        Ultimo = Anterior;
                    }
                    else
                    {
                        Anterior.Siguiente = Actual.Siguiente;
                        Actual.Siguiente.Anterior = Anterior;

                    }
                }
                Anterior = Actual;
                Actual = Actual.Siguiente;
            }
        }
        public void ModificarNodo(int x)
        {
            Nodo2 Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    if (Actual.Dato == x)
                    {
                        Console.WriteLine("Ingrese el nuevo valor");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nodo Modificado");
                        
                    }
                    Actual = Actual.Siguiente;
                }
            }
        }
        public void Imprimir()
        {
            Nodo2 Actual = Primero;

            while (Actual != null)
            {
                Console.WriteLine("" + Actual.Dato);
                Actual = Actual.Siguiente;
            }
        }
    }
}
