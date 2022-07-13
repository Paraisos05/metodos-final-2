using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class InventarioPromedio : Form
    {
        public InventarioPromedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numPiezasOrdenar = int.Parse(tb_Piezas.Text);
            double inventarioPromedio = (numPiezasOrdenar / 2);
            tb_Result.Text = inventarioPromedio.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
