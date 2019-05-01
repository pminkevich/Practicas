using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Cola2
    {
        private Nodo Primero, Ultimo;

        public Cola2()
        {
            Primero = null;
            Ultimo = null;
        }
        public void InsertarNodo(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = x;

            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;

            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
        public void EliminarNodo(int x)
        {
            Nodo Actual = Primero;
            Nodo Anterior = null;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    if (Actual.Dato == x)
                    {
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if(Actual==Ultimo )
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }

            }
            else
            {
                Console.Write("Cola Vacia");
            }
        }
        public void ModificarNodo(int x)
        {
            Nodo Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    if (Actual.Dato == x)
                    {
                        Console.WriteLine("Ingrese el dato nuevo");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dato Modificado");
                    }
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.Write("Cola Vacia");
            }

    }
        public void Imprimir()
        {
            Nodo Actual = Primero;

            while (Actual != null)
            {
                Console.WriteLine("" + Actual.Dato);
                Actual = Actual.Siguiente;
            }
        }
    }
}
