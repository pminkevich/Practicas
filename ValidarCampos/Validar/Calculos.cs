using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp17
{
    class Calculos
    {
        private float numero1;
        private float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public Calculos(float pNum1, float pNum2)
        {
            this.Numero1 = pNum1;
            this.Numero2 = pNum2;
        }

        public float Suma()
        {
            return Numero1 + Numero2;
        }
    }
}
