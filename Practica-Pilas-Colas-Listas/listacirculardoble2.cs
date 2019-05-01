using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class listacirculardoble2
    {
        private Nodo2 Primero, Ultimo;
        public listacirculardoble2()
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
               
                nuevo.Siguiente = Primero;
                nuevo.Anterior = Ultimo;
                Primero = nuevo;
                Ultimo = nuevo;

            }
            else
            {
               
                nuevo.Siguiente = Primero;
                nuevo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
                Primero.Anterior = Ultimo;

            }
        }
        public void EliminarNodo(int x)
        {
            Nodo2 Actual = Primero;

            do
            {
                if (Actual.Dato == x)
                {
                    if (Actual == Primero)
                    {
                        Primero = Primero.Siguiente;
                        Primero.Anterior = Ultimo;
                        Ultimo.Siguiente = Primero;
                    }
                    else if (Actual == Ultimo)
                    {
                        Ultimo.Anterior = Ultimo;
                        Ultimo.Siguiente = Primero;
                        Primero.Anterior = Ultimo;
                    }
                    else
                    {
                        Actual.Anterior.Siguiente  = Actual.Siguiente;
                        Actual.Siguiente.Anterior = Actual.Anterior;

                    }
                }
                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }
        public void ModificarNodo(int x)
        {
            Nodo2 Actual = Primero;

            do
            {
                if (Actual.Dato == x)
                {
                    Console.WriteLine("Ingrese el nuevo valor");
                    Actual.Dato = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dato modificado");
                }

                Actual = Actual.Siguiente;
            } while (Actual != Primero);
        }
        public void Imprimir()
        {
            Nodo2 Actual = Primero;

            do
            {
                Console.WriteLine("" + Actual.Dato);
                Actual = Actual.Siguiente;

            } while (Actual != Primero);
        }
    }
}
