using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class ListaCircularDoble
    {
        private Nodo2 Primero, Ultimo;


        public ListaCircularDoble()
        {
            Primero = null;
            Ultimo = null;

        }
        public void InsertarNodo()
        {
            Nodo2 nuevo = new Nodo2();
            Console.WriteLine("Ingrese el valor del nuevo nodo");
            string respuesta = Console.ReadLine();
            nuevo.Dato = int.Parse(respuesta);

            if (Primero == null)
            {
                
                Primero = nuevo;
                Ultimo = nuevo;
                Primero.Siguiente = Primero;
                Primero.Anterior = Ultimo;
                Ultimo.Siguiente = Primero;
                Ultimo.Anterior = Ultimo;
                
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
        public void DesplegarLista()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;

            if (Primero != null)
            {
                do
                {
                    Console.WriteLine("\n\n" + Actual.Dato);
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
            Nodo2 Actual = new Nodo2();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el Nodo A buscar");
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
                while (Actual != Primero && Encontrado != true);
                if(!Encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }

            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public int Extraer()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;
            if (Primero != null)
            {
                
                Primero = Primero.Siguiente;
                Primero.Anterior = Ultimo;
                Ultimo.Siguiente = Primero;
                return Actual.Dato;
                
            }
            else
            {
                return int.MaxValue;
            }
        }
        public void Ruleta()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;
            Random  Aleatorio = new Random();
            int NumeroElegido = Aleatorio.Next(0, 99); 

            if (Primero != null)
            {
                Console.WriteLine("El numero Elegido es" + NumeroElegido);

                for(int f=0; f < 10; f++)
                { 
                do
                {
                    Console.WriteLine("\n\n " + Actual.Dato);
                    if (Actual.Dato == NumeroElegido)
                    {


                        Console.WriteLine("Ganaste!!!");
                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero);
                }

                if (Actual.Dato!=NumeroElegido)
                {
                    Console.WriteLine("No tuviste suerte");
                }

            }
            else
            {
                Console.WriteLine("Sin datos");
            }
        }
        public void ModificarNodo()
        {
            Nodo2 Actual = new Nodo2();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a modificar");
            string respuesta = Console.ReadLine();
            int Abuscar = int.Parse(respuesta);

            if (Primero != null)
            {
                do
                {
                    if (Actual.Dato == Abuscar)
                    {
                        Encontrado = true;
                        Console.WriteLine("Ingrese el nuevo dato");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nodo Modificado");

                    }
                    Actual = Actual.Siguiente;
                }
                while (Actual != Primero && Encontrado == false);

                if (!Encontrado)
                {
                    Console.WriteLine("Nodo NO encontrado");
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
        public void EliminarNodo()
        {
            Nodo2 Actual, Anterior = new Nodo2();
            Actual = Primero;
            Anterior = null;
            bool Encontrado = false;
            Console.WriteLine("Ingrese el nodo a eliminar \n\n");
            string respuesta = Console.ReadLine();
            int AEliminar = int.Parse(respuesta);

            if (Primero != null)
            {
                do
                {
                    if (Actual.Dato == AEliminar)
                    {
                        Encontrado = true;

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                            Primero.Anterior = Ultimo;
                            Ultimo.Siguiente = Primero;

                        }
                        else if (Actual == Ultimo)
                        {

                            Anterior.Siguiente = Primero;
                            Primero.Anterior = Anterior;
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
                while (Actual != Primero && Encontrado == false);
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }
    }
    
}
