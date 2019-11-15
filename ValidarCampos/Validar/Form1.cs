using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar.SoloLetras(KeyPressEventArgs );
            Calculos Calcu = new Calculos(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            float result;
            result=Calcu.Suma();
            txtResult.Text = Convert.ToString(result);
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
