using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinClass
{
    public class Cola
    {
        private Nodo Primero, Ultimo;

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void Insertar(string pCadBin)
        {
            string CadBin = pCadBin;

            for (int i = 0; i < CadBin.Length; i++)
            {
                Nodo nuevo = new Nodo();
                nuevo.Dato = CadBin.ElementAt(i);

                if (Primero == null)
                {
                    nuevo.Siguiente = null;
                    Primero = nuevo;
                    Ultimo = nuevo;
                    Ultimo.Siguiente = null;

                }
                else
                {
                    Ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    Ultimo = nuevo;


                }
            }
           
            

        }
        public int PasarDec()
        {
            Nodo Actual = Primero;
            int suma = 0;
            Double i = 0;
            while (Actual != null)
            {
               
               // int n = Convert.ToInt32(Math.Pow(2, i));
                
                
                if (Actual.Dato == '1')
                {
                    suma += Convert.ToInt32(Math.Pow(2, i));
                }

                i++;
                Actual = Actual.Siguiente;
                

            }
            return suma;

        }
    }
}
