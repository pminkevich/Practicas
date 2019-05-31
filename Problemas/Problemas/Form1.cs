using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problemas
{
    public partial class Form1 : Form
    {
        //Lista para guardar los resultados
        List<int> Lresultados = new List<int>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Metodo para limpiar el TextBox
        private void Limpiar()
        {
            if (txtConsola.Text != string.Empty)
            {
                txtConsola.Text = string.Empty;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Numeros Impares: \r\n";
            
            //Relleno la lista impares con los el metodo impares de CEjercicios
            Lresultados = CEjercicios.Impares();
            
            //Recorro la lista
            foreach(int imp in Lresultados)
            {
                txtConsola.Text += imp + "\r\n";
            }
        }

        private void txtPares_Click(object sender, EventArgs e)
        {
            Limpiar(); //Limpio la Consola
            txtConsola.Text = "Numeros Pares: \r\n";

            //Relleno la lista Pares con el metodo estatico  de la clase
            Lresultados = CEjercicios.Pares(); 
            //Recorro la lista
            foreach (int par in Lresultados)
            {
                txtConsola.Text += par + "\r\n";
            }
        }

        private void txtCeroalCien_Click(object sender, EventArgs e)
        {
            Limpiar(); //Limpio la Consola
            txtConsola.Text = "Numeros del Cero al Cien \r\n"; //Titulo

            Lresultados = CEjercicios.CeroalCien();

            foreach (int num in Lresultados)
            {
                txtConsola.Text += num + "\r\n";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar(); //Limpio la Consola
            txtConsola.Text = "Numeros del Cien a Cero \r\n"; //Titulo

            //LLeno la lista con el metodo estatico de CEjercicios
            Lresultados = CEjercicios.CeroalCien();

            Lresultados.Reverse(); //Doy vuelta la lista

            //Recorro la lista
            foreach (int num in Lresultados)
            {
                txtConsola.Text += num + "\r\n";
            }
            

        }

        private void txtMultiplos3_Click(object sender, EventArgs e)
        {
            Limpiar();//Limpio la Consola
            txtConsola.Text = "Numeros Multiplos de 3: \r\n"; //Titulo

            Lresultados = CEjercicios.Multiplos3();//Relleno Rmultiplos3

            foreach (int num in Lresultados)
            {
                txtConsola.Text += num + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Numero; //Se ingresara en Numero los datos ingresados
            int Resultado;//Variable para guardar los resultados del Metodo Sumar 

            Numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Numero",
                                    "Sumaremos los numeros  que lo anteceden");

            Resultado=CEjercicios.Sumar(Convert.ToInt32(Numero));

            MessageBox.Show("El Resultado es: " + Resultado);

        }

        private void txtMuestraNum_Click(object sender, EventArgs e)
        {
            string Numero;  
            
            Numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Numero", "Se mostrararan de forma Ascendente los anteriores");
            
            //Limpio la Consola
            Limpiar(); 
            //Guardo los resultados en Lresultado
            Lresultados = CEjercicios.Mostrar(Convert.ToInt32(Numero));
            //Recorro Lresultados
            foreach(int num in Lresultados)
            {
                txtConsola.Text += num + "\r\n";
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Numero;
            int Resultado;
            //Se guarda en Numero el Resultado del InputBox
            Numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Numero", "Se contaran los multiplos de 3 de los antecesores");
            //Obtenemos el Resultado del metodo ContarM3
            Resultado = CEjercicios.ContarM3(Convert.ToInt32(Numero));

            MessageBox.Show("El Total de Multiplos de 3 es: " + Resultado);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Numeros Primos del 1 al 100 \r\n";

           Lresultados = CEjercicios.MostrarPrimos();

            foreach (int num in Lresultados)
            {
                txtConsola.Text += num + "\r\n";
            }

        }

        private void btnSumayMul_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Suma los 10 Numeros y Tambien los Multiplica";
            string Resultado;
            Resultado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese 10 numeros separados por coma", "Se Sumaran y tambien multiplicaran");
            string[] Numeros = Resultado.Split(',');

            if (Numeros.Length != 10)
            {
                MessageBox.Show("Debe Ingresar diez numeros", "Ha Ingresado " + Numeros.Length);
                this.btnSumayMul_Click(this, e);
            }
            else
            {
                txtConsola.Text += "\r\n El Resultado de la suma es: " + CEjercicios.SumaCadena(Numeros);
                txtConsola.Text += "\r\n El Resultado de la Multiplicación es: " + CEjercicios.MultiCadena(Numeros);
            }
            

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Intercambio de Valores";

            string Num1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Valor", "Se guardara en N1");

            string Num2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Valor", "Se guardara en N2");
            int N1, N2;
            N1 = Convert.ToInt32(Num1);
            N2 = Convert.ToInt32(Num2);
            txtConsola.Text += "\r\n El Valor de N1 es: " + N1;
            txtConsola.Text += "\r\n El Valor de N2 es: " + N2;
            txtConsola.Text += "\r\n Intercambio de Valores:";

            CEjercicios.Swap(ref N1, ref N2);

            txtConsola.Text += "Se ha llevado a cabo el intercambio.";
            txtConsola.Text += "\r\n El Valor de N1 es: " + N1;
            txtConsola.Text += "\r\n El Valor de N2 es: " + N2;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Mostrar el Cuadrado y Cubo del Numero Ingresado:";
            string Numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un Numero");
            if (Numero.Any(x => char.IsNumber(x)))
            {
                Double Cuadrado = Math.Pow(Convert.ToDouble(Numero), 2);
                Double Cubo = Math.Pow(Convert.ToDouble(Numero), 3);

                txtConsola.Text += "\r\n El Cuadrado es: " + Cuadrado.ToString();
                txtConsola.Text += "\r\n El Cubo es: " + Cubo.ToString();
            }
            else
            {
                MessageBox.Show("No Ingreso un Numero");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtConsola.Text = "Numero pares con LINQ";
            Lresultados = CEjercicios.CeroalCien();

            var Pares = Lresultados.Where(n => n % 2 == 0);

            foreach(int Num in Pares)
            {
                txtConsola.Text += "\r\n " + Num;
            }
        
        }
    }
}
