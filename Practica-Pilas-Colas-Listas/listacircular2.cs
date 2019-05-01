using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class listacircular2
    {
        private Nodo Primero, Ultimo;

        public listacircular2()
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
                Primero.Siguiente = Primero;
                Ultimo.Siguiente = Primero;

            }
            else
            {
                nuevo.Siguiente = Primero;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;

            }
        }

        public void EliminarNodo(int x)
        {
            Nodo Actual = Primero;
            Nodo Anterior = null;

            do
            {
                if (Actual.Dato == x)
                {
                    if (Actual == Primero)
                    {
                        Primero = Primero.Siguiente;
                    }
                    else if (Actual == Ultimo)
                    {
                       
                        Ultimo = Anterior;
                        Ultimo.Siguiente = Primero;

                    }
                    else
                    {
                        Anterior.Siguiente = Actual.Siguiente;
                    }
                   
                }
                Anterior = Actual;
                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }
        public void ModificarNodo(int x)
        {
            Nodo Actual = Primero;

            do
            {
                if (Actual.Dato == x)
                {
                    Console.WriteLine("Ingrese el nuevo dato");
                    Actual.Dato = int.Parse(Console.ReadLine());
                    Console.Write("Nodo Modificado");
                }
                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }
        public void Imprimir()
        {
            Nodo Actual = Primero;
            do
            {
                Console.WriteLine("\n \n" + Actual.Dato);
                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }
    }
}
