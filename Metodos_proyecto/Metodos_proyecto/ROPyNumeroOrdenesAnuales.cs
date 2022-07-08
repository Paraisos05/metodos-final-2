using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_proyecto
{
    public partial class ROPyNumeroOrdenesAnuales : Form
    {
        public ROPyNumeroOrdenesAnuales()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lResult_Click(object sender, EventArgs e)
        {

        }

        private void lProduccion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ostras_Click(object sender, EventArgs e)
        {
            double D;
            double Q;
            double resul1;

            try
            {
                D = double.Parse(DAnual.Text);
                Q = double.Parse(textBox2.Text);
                resul1 = D / Q;
                Console.WriteLine("D/Q: " + (D / Q));
                lResult.Text = resul1.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}Exception caught.", ex);

            }



        }

        private void DAnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double d;
            double L;
            double resul2;

            try
            {
                d = double.Parse(textBox3.Text);
                L = double.Parse(textBox4.Text);
                resul2 = d * L;
                Console.WriteLine("d*L: " + (d * L));
                label3.Text = resul2.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}Exception caught.", ex);

            }
        }

        private void ROPyNumeroOrdenesAnuales_Load(object sender, EventArgs e)
        {

        }
    }
}
