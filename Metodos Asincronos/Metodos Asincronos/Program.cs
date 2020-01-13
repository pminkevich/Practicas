using System;
using System.Threading;
using System.Threading.Tasks;

namespace Metodos_Asincronos
{
    class Program
    {
        static  void Main(string[] args)
        {
            

            Proceso1();
            Proceso2();
            Proceso3();
            Proceso4();
            Proceso5();
           

        }



        private static async void Proceso1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--");
            Console.WriteLine("Iniciando Proceso 1");
            
            await InicioProc1();
            

        }
        private static async Task InicioProc1()
        {

            await Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--");
            Console.WriteLine("Finalizando proceso 1");
        }

        private static async void Proceso2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--");
            Console.WriteLine("Iniciando Proceso 2");
           
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
            });
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--");
            Console.WriteLine("Finalizando Proceso 2");
        }

        private static async void Proceso3()
        {
            await IniciarProc3();
        }

        private static async Task IniciarProc3()
        {
           await Task.Run(()=> {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--");
                Console.WriteLine("Iniciando Proceso 3");
                Thread.Sleep(6000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("--");
                Console.WriteLine("Finalizando proceso 3");


            });
            
        }

        private static async void Proceso4()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--");
            Console.WriteLine("Iniciando Proceso 4");
            await Task.Run(()=> {

                Thread.Sleep(9000);
            });
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--");
            Console.WriteLine("Finaliza Proceso 4");
        }

        private static void Proceso5()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--");
            Console.WriteLine("Iniciando Proceso 5");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Proceso 5 ejecutandose");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--");
            Console.WriteLine("Finaliza Proceso 5");
        }

     
    }
}
