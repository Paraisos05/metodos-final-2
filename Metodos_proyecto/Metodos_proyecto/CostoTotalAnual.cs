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
    public partial class CostoTotalAnual : Form
    {
        public CostoTotalAnual()
        {
            InitializeComponent();
        }

        private void CostoTotalAnual_Load(object sender, EventArgs e)
        {

        }

        private void tbPiezas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lResult_Click(object sender, EventArgs e)
        {

        }

        private void tbProduccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDemandaDiaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lDemandaDiaria_Click(object sender, EventArgs e)
        {

        }

        private void lProduccion_Click(object sender, EventArgs e)
        {

        }

        private void lPiezasOrdenar_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
            double Q;
            double Co;
            double Ch;
            double result;
            try
            {
                d = double.Parse(DAnual.Text);
                Q = double.Parse(textBox2.Text);
                Co = double.Parse(textBox3.Text);
                Ch = double.Parse(textBox4.Text);
                result = ((d / Q) * Co) + ((Q / 2) * Ch);
                Console.WriteLine("(d/Q)*Co : " + (d / Q) * Co);
                Console.WriteLine("Q/2 * Ch" + (Q / 2) * Ch);
                Console.WriteLine(result);
                lResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}Exception caught.", ex);

            }
        }
    }
}