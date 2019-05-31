using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinClass;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPasarDec_Click(object sender, EventArgs e)
        {
            Cola Bin = new Cola();
            Bin.Insertar(txtBin.Text);
            int Resultado = Bin.PasarDec();
            MessageBox.Show("El Resultado es " + Resultado);
        }
    }
}
