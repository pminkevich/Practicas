using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroDetalleWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (Models.MaestroDetalleEntities db= new Models.MaestroDetalleEntities())
            {
                dataGridView1.DataSource = db.venta.Select(d=>new { d.id,d.fecha,d.total}).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
            Refresh();
        }
    }
}
