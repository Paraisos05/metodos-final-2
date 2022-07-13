using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class CostoAnualPedido : Form
    {
        public CostoAnualPedido()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double demandaAnual = double.Parse(tb_Demanda.Text);
            double numPiezasOrdenar = double.Parse(tb_piezas.Text);
            double costoOrdenar = double.Parse(tb_CostoOrdenar.Text);

            double costoAnualOrdenar = (demandaAnual / numPiezasOrdenar) * costoOrdenar;
            txResult.Text = costoAnualOrdenar.ToString();
        }
    }
}
