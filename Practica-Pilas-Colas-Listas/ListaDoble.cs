using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class ListaDoble
    {
        private Nodo2 Primero, Ultimo;

        public ListaDoble()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodo2 nuevo = new Nodo2();
            Console.WriteLine("\n Ingrese el valor del nodo a insertar \n\n");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {

                nuevo.Siguiente = null;
                nuevo.Anterior = null;
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = null;
                nuevo.Anterior = Ultimo;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
                

            }
        }
        public void DesplegarLista()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("\n\n" + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }
        public void DesplegarLista2()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Ultimo ;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("\n\n" + Actual.Dato);
                    Actual = Actual.Anterior ;
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }
        public void BuscarNodo()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a buscar");
            string resultado = Console.ReadLine();
            int Abuscar = int.Parse(resultado);

            if (Primero != null)
            {
                while(Actual!=null && Encontrado == false)
                {
                    if(Actual.Dato==Abuscar)
                    {
                        Encontrado = true;
                        Console.WriteLine("\n Nodo Encontrado");
                    }

                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo No Encontrado");
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");

            }
        }

    }
}
