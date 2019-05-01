using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Cola
    {
        private Nodo Primero, Ultimo;

        public Cola()
        {
            Primero = null;
            Ultimo = null;

        }
        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Inserte el dato del nuevo nodo");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                nuevo.Siguiente = null;
                Primero = nuevo;
                Ultimo = nuevo;
                Console.WriteLine("Nodo Insertado");

            }
            else
            {
                nuevo.Siguiente = null;
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
                Console.WriteLine("Nodo Insertado");

            }
        }
        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine("" + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Cola Vacia");
            }
        }
        public int Extraer()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Actual != null)
            {
                Primero = Primero.Siguiente;

                return Actual.Dato;
            }
            else
            {
                return int.MaxValue;
            }
        }
        public void BuscarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a buscar");
            string resultado = Console.ReadLine();
            int Abuscar = int.Parse(resultado);

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == Abuscar)
                    {
                        Encontrado = true;
                        Console.WriteLine("\n Nodo Encontrado");
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Nodo No Encontrado");
                }
            }
            else
            {
                Console.WriteLine("Cola vacia");
            }

        }
        public void EliminarNodo()
        {
            Nodo Actual,Anterior = new Nodo();
            Actual = Primero;
            Anterior = null;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a Eliminar");
            string resultado = Console.ReadLine();
            int AEliminar = int.Parse(resultado);

            if (Primero != null)
            {
                while(Actual!=null && Encontrado == false)
                {
                    if (Actual.Dato == AEliminar)
                    {
                        Encontrado = true;
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                            Console.WriteLine("Nodo Eliminado");
                        }
                        else if (Actual == Ultimo)
                        {
                            
                            Ultimo = Anterior;
                            Ultimo.Siguiente = null;
                            Console.WriteLine("Nodo Eliminado");

                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                            Console.WriteLine("Nodo Eliminado");
                        }
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Cola Vacia");
            }
        }
        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a modificar");
            string resultado = Console.ReadLine();
            int AModificar = int.Parse(resultado);

            if (Primero != null)
            {
                while(Actual!=null && Encontrado == false)
                {
                    if(Actual.Dato==AModificar)
                    {
                        Encontrado = true;
                        Console.WriteLine("\n Nodo Encontrado, Ingrese el nuevo valor");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Nodo Modificado");
                    }

                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("Cola Vacia");
                }
            }
            else
            {
                Console.WriteLine("Cola vacia");
            }

    }

}
}
