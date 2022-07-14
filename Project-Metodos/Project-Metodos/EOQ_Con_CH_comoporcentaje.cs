using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class EOQ_Con_CH_comoporcentaje : Form
    {
        public EOQ_Con_CH_comoporcentaje()
        {
            InitializeComponent();
        }

        private void EOQ_Con_CH_comoporcentaje_Load(object sender, EventArgs e)
        {

        }

        private void ostras_Click(object sender, EventArgs e)
        {


            double D;
            double Co;
            double I;
            double C;
            double resul1;
            double resul2;

            try
            {
                D = double.Parse(textBox2.Text);
                Co= double.Parse(textBox4.Text);
                I = double.Parse(textBox3.Text);
                C = double.Parse(textBox1.Text);
                resul1 = ((2*D*Co)/(I*C));
                resul2 = Math.Sqrt(resul1);
                Console.WriteLine("Resultado: " + ((2 * D * Co) / (I * C)));
                lResult.Text = resul2.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}Exception caught.", ex);

            }






        }

        private void lPiezasOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void lDemandaDiaria_Click(object sender, EventArgs e)
        {

        }

        private void lProduccion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
