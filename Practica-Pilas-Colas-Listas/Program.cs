using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Pila_colas_y_mas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila p = new Pila();
            //p.InsertarNodo();
            //p.InsertarNodo();
            //p.InsertarNodo();
            //p.InsertarNodo();
            //p.InsertarNodo();
            //p.DesplegarLista();
            //int Aextraer = p.Extraer();
            //Console.WriteLine("se extrajo el nodo" + Aextraer);
            //p.DesplegarLista();
            //p.BuscarNodo();
            //p.ModificarNodo();
            //p.DesplegarLista();
            //p.EliminarNodo();
            //p.DesplegarLista();
            //Console.ReadKey();
            //Cola c = new Cola();
            //c.InsertarNodo();
            //c.InsertarNodo();
            //c.InsertarNodo();
            //c.InsertarNodo();
            //c.InsertarNodo();
            //c.DesplegarLista();
            //Console.WriteLine("Extrayendo  primero");
            //int extraido = c.Extraer();
            //Console.WriteLine("Nodo " + extraido + "fuera de la cola");
            //c.DesplegarLista();
            //c.BuscarNodo();
            //c.DesplegarLista();
            //c.EliminarNodo();
            //c.DesplegarLista();
            //c.ModificarNodo();
            //c.DesplegarLista();

            //ListaDoble ld = new ListaDoble();
            //ld.InsertarNodo();
            //ld.InsertarNodo();
            //ld.InsertarNodo();
            //ld.InsertarNodo();
            //ld.InsertarNodo();
            //ld.DesplegarLista();
            //ld.DesplegarLista2();
            //ld.BuscarNodo();

            //ListaCircular lc = new ListaCircular();
            //lc.InsertarNodo();
            //lc.InsertarNodo();
            //lc.InsertarNodo();
            //lc.InsertarNodo();
            //lc.InsertarNodo();
            //lc.DesplegarLista();
            //lc.BuscarNodo();
            //lc.ModificarNodo();
            //lc.DesplegarLista();
            //lc.EliminarNodo();
            //lc.DesplegarLista();

            //ListaCircularDoble lcd = new ListaCircularDoble();
            //lcd.InsertarNodo();
            //lcd.InsertarNodo();
            //lcd.InsertarNodo();
            //lcd.InsertarNodo();
            //lcd.InsertarNodo();
            //lcd.DesplegarLista();
            //lcd.BuscarNodo();
            //Console.WriteLine("\n Extrayendo el primero");
            //int Primero = lcd.Extraer();
            //Console.WriteLine("\n Se extrajo el " + Primero);

            //lcd.DesplegarLista();
            //lcd.Ruleta();
            //lcd.ModificarNodo();
            //lcd.DesplegarLista();
            //lcd.EliminarNodo();
            //lcd.DesplegarLista();
            //lcd.DesplegarLista();

            //pila2 pp = new pila2();
            //pp.Insertar(12);
            //pp.Insertar(13);
            //pp.Insertar(14);
            //pp.Insertar(15);
            //pp.Imprimir();
            //pp.EliminarNodo(13);
            //pp.Imprimir();
            //pp.ModificarNodo(12);
            //pp.Imprimir();

            //Cola2 cc = new Cola2();
            //cc.InsertarNodo(23);
            //cc.InsertarNodo(24);
            //cc.InsertarNodo(25);
            //cc.InsertarNodo(26);
            //cc.Imprimir();
            //cc.EliminarNodo(24);
            //cc.Imprimir();
            //cc.ModificarNodo(26);
            //cc.Imprimir();
            //listadoble2 ll = new listadoble2();
            //ll.InsertarNodo(23);
            //ll.InsertarNodo(24);
            //ll.InsertarNodo(25);
            //ll.InsertarNodo(26);
            //ll.InsertarNodo(27);
            //ll.Imprimir();
            //ll.EliminarNodo(24);
            //ll.Imprimir();
            //ll.ModificarNodo(23);
            //ll.Imprimir();

            //listacircular2 lc = new listacircular2();
            //lc.InsertarNodo(35);
            //lc.InsertarNodo(36);
            //lc.InsertarNodo(37);
            //lc.InsertarNodo(38);
            //lc.InsertarNodo(39);
            //lc.Imprimir();
            //lc.EliminarNodo(37);
            //lc.Imprimir();
            //lc.ModificarNodo(35);
            //lc.Imprimir();

            listacirculardoble2 lcd = new listacirculardoble2();
            lcd.InsertarNodo(21);
            lcd.InsertarNodo(22);
            lcd.InsertarNodo(23);
            lcd.InsertarNodo(24);
            lcd.Imprimir();
            lcd.EliminarNodo(22);
            lcd.Imprimir();
            lcd.ModificarNodo(24);
            lcd.Imprimir();


            Console.ReadLine();




            
        }
    }
}
