using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class ListaCircular
    {
        private Nodo Primero, Ultimo;

        public ListaCircular()
        {
            Primero = null;
            Ultimo = null;

        }
        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato del nuevo nodo");
            string resultado = Console.ReadLine();
            nuevo.Dato = int.Parse(resultado);


            if (Primero == null)
            {
                
                Primero = nuevo;
                Primero.Siguiente = Primero;
                Ultimo = nuevo;
                Ultimo.Siguiente = Primero;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                do
                {
                    Console.WriteLine("\n " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero);
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
    }

        public void BuscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a buscar");
            string respuesta = Console.ReadLine();
            int Abuscar = int.Parse(respuesta);

            if (Primero != null)
            {
                do
                {
                    if (Actual.Dato == Abuscar)
                    {
                        Encontrado = true;
                        Console.WriteLine("Nodo Encontrado");
                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && Encontrado==false);

                if (!Encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }

        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a modificar");
            string respuesta = Console.ReadLine();
            int AModificar = int.Parse(respuesta);

            if (Primero != null)
            {
                do
                {
                    if(Actual.Dato==AModificar)
                    {
                        Console.WriteLine("Ingrese el nuevo valor");
                        Actual.Dato = int.Parse(Console.ReadLine());
                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && Encontrado == false);
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo No Encontrado");
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }
        public void EliminarNodo()
        {
            Nodo Actual,Anterior = new Nodo();
            Actual = Primero;
            Anterior = null;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a eliminar");
            string respuesta = Console.ReadLine();
            int AEliminar = int.Parse(respuesta);

            if (Primero != null)
            {
                do
                {
                    if(Actual.Dato==AEliminar)
                    {
                        Encontrado = true;

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                            
                        }
                        else if(Actual==Ultimo)
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
                }
                while (Actual != Primero && Encontrado == false);

                if (!Encontrado)
                {
                    Console.WriteLine("Nodo No Encontrado");
                }
            }
            else
            {
                Console.WriteLine("Lista Vacia");
            }
        }
    }
}
