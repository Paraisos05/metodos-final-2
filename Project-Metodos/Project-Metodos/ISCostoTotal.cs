using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class ISCostoTotal : Form
    {
        readonly MethodIS iS = new MethodIS();
        public ISCostoTotal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double D = Convert.ToDouble(tb_Demanda.Text);
            double Ch = Convert.ToDouble(tb_Ch.Text);
            double Co = Convert.ToDouble(tb_Co.Text);
            string result = iS.IS_CostoTotalAnual(D,Ch,Co);
            var resultdivide = result.Split(",");
            txOptimo.Text = resultdivide[0];
            txResultCTA.Text = resultdivide[1];
            txResultPedidos.Text = resultdivide[2];
            txResultIP.Text = resultdivide[3];
        }
    }
}
