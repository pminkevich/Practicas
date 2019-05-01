using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Pila
    {
        private Nodo Primero;

        public Pila()
        {
            Primero = null;

        }

        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato nuevo");
            string resultado = Console.ReadLine();
            nuevo.Dato = int.Parse(resultado);

           
            nuevo.Siguiente = Primero;
            Primero = nuevo;
            
        }
        public void DesplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("pila vacia");
            }
        }
        public int Extraer()
        {
            Nodo NodoArriba = new Nodo();
            NodoArriba = Primero;

            if (Primero != null)
            {
                int informacion = NodoArriba.Dato;
                Primero = Primero.Siguiente;
                return informacion ;
                
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
            string respuesta = Console.ReadLine();
            int Abuscar = int.Parse(respuesta);

            if (Primero != null)
            {
                while (Actual != null && Encontrado==false)
                {
                    if (Actual.Dato == Abuscar)
                    {
                        Encontrado = true;
                        Console.WriteLine("Nodo Encontrado" + Actual.Dato);
                    }
                    Actual = Actual.Siguiente;
                }
                if(!Encontrado)
                {
                    Console.WriteLine("Nodo No Encontrado");
                }
            }
            else
            {
                Console.WriteLine("Pila vacia");
            }
        }
        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el valor a modificar");
            string respuesta = Console.ReadLine();
            int Amodificar = int.Parse(respuesta);

            if (Primero != null)
            {
                while(Actual!=null && Encontrado != true)
                {
                    if(Actual.Dato==Amodificar)
                    {
                        Encontrado = true;
                        Console.WriteLine("\n Nodo Encontrado \n\n");
                        Console.WriteLine("Ingrese el nuevo valor \n");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nodo Modificado");
                        
                    }
                    Actual = Actual.Siguiente;
                }
                if(!Encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("\n Pila vacia\n");
            }
        }

        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a eliminar");
            string respuesta = Console.ReadLine();
            int Aeliminar = int.Parse(respuesta);

            if (Primero != null)
            {
                while(Actual != null && Encontrado == false)
                {
                    Console.WriteLine("while");
                    if (Actual.Dato==Aeliminar)
                    {
                        Encontrado = true;
                        Primero = Primero.Siguiente;
                        Console.WriteLine("Nodo Eliminado");
                    }
                    Actual = Actual.Siguiente;
                }
                if(!Encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Pila vacia");
            }
        }
    }
}
