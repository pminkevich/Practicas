using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class pila2
    {
        private Nodo Primero;

        public pila2()
        {
            Primero = null;

        }

        public void Insertar(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = x;
            
                nuevo.Siguiente = Primero;
                Primero = nuevo;
            
        }

        public void EliminarNodo(int x)
        {
            Nodo Actual = new Nodo();
            Nodo Anterior = null;
            Actual = Primero;
            int AEliminar = x;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    if(Actual.Dato==AEliminar)
                    {
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
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

        }
        public void ModificarNodo(int x)
        {
            Nodo Actual = Primero;

            if (Primero != null)
            {
                while (Actual!=null)
                {
                    if (Actual.Dato == x)
                    {
                        Console.WriteLine("Ingrese el nuevo valor");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Dato Modificado");
                    }
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Pila Vacia");
            }
        }
        public void Imprimir()
        {
            Nodo Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("" + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
        }
    }
}
