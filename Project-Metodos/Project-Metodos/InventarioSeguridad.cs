using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class InventarioSeguridad : Form
    {
        readonly MethodIS iS = new MethodIS(); 
        public InventarioSeguridad()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int D = Convert.ToInt32(tb_Demanda.Text);
            double desv = Convert.ToDouble(tb_Desviaciones.Text);
            int alpha = Convert.ToInt32(tb_DesviacionEstandar.Text);
            string result;
            if (cb_Percent.Checked) {
                result = iS.IS_nivelServicio(D, desv, alpha);
            }
            else {
                
                result = iS.IS_desviaciones(D, desv, alpha);
            }
            var resultdivide = result.Split(",");
            txResultROP.Text = resultdivide[0];
            txResultIS.Text = resultdivide[1];

        }
    }
}
