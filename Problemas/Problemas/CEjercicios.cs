using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas
{
    class CEjercicios
    {


        public static List<int> Valores;


        #region "Metodos Estaticos"
        //Guarda en Valores los numeros impares de 1 al 100
        public static List<int> Impares()
        {
            Valores = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Valores.Add(i);
                }
            }
            return Valores;
        }
        //Guarda en Valores los numeros pares del 1 al cien
        public static List<int> Pares()
        {
            Valores = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Valores.Add(i);
                }
            }
            return Valores;
        }
        //Guarda en Valores los numeros del cero al cien
        public static List<int> CeroalCien()
        {
            Valores = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                Valores.Add(i);
            }
            return Valores;
        }
        //Guarda en Valores los numeros que sean multiplos de 3 hasta el 100
        public static List<int> Multiplos3()
        {
            Valores = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Valores.Add(i);
                }
            }
            return Valores;
        }
        //Metodo que suma los numeros que anteceden al del parametro
        public static int Sumar(int pNumero)
        {
           
            int result=0;

            for (int i = 0; i < pNumero; i++)
            {
                result += i;
                
            }
            return result;
        }
        //Metodo que muestra los numeros que anteceden al del parametro
        public static List<int> Mostrar(int pNumero)
        {
            Valores = new List<int>();

            
            for (int i = 0; i < pNumero; i++)
            {
                Valores.Add(i);

            }
            return Valores;
        }
        public static int ContarM3(int pNumero)
        {

            int result = 0;

            for (int i = 0; i < pNumero; i++)
            {
                if (i % 3 == 0)
                {
                    result++;
                }
                

            }
            return result;
        }
        public static List<int> MostrarPrimos()
        {
            //Inicializo la Lista
            Valores = new List<int>();

            //Recorro del uno al Cien
            for (int i = 2; i < 100; i++)
            {
                //inicializo a cero a
                int a=0;

                //cada numero lo divido por todos los numeros 
                //hasta llegar al elegido (y lo incluyo)
                for (int Divisor = 1; Divisor <= i ; Divisor++)
                {
                    //si el resto es cero actualizo a + 1 
                    if (i % Divisor == 0)
                    {
                        a++;
                    }

                   
                    
                }
                //si se pudo dividir menos de 2 veces o 2 veces
                //agrego a la lista
                if (a <= 2)
                {
                    Valores.Add(i);
                }
               
            }
            return Valores;
        }

        public static int SumaCadena(string[] pNumeros)
        {
            int suma = 0;
            string[] Numeros = pNumeros;

            foreach (string Num in Numeros)
            {
                suma+= Convert.ToInt32(Num);
            }
            return suma;
        }
        public static int MultiCadena(string[] pNumeros)
        {
            int multi = 1;
           

            string[] Numeros = pNumeros;
            

            foreach (string Num in Numeros)
            {
                multi *= Convert.ToInt32(Num);
                             
               
            }
            return multi;
        }
        public static void Swap(ref int pNum1, ref int pNum2)
        {
            int Temporal;
            Temporal = pNum1;
            pNum1 = pNum2;
            pNum2 = Temporal;
        }



        #endregion

    }
}
