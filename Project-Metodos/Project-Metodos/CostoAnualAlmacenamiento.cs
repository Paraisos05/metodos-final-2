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
    public partial class CostoAnualAlmacenamiento : Form
    {
        public CostoAnualAlmacenamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CostoAnualAlmacenamiento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double d;
            double Q;
            double p;
            double Ch;
            double result;
            try
            {
                d = double.Parse(tbDemandaDiaria.Text);
                Q = double.Parse(tbPiezas.Text);
                p = double.Parse(tbProduccion.Text);
                Ch = double.Parse(tbCostoAnualAlmacenar.Text);
                result = (Q / 2) * (1 - d / p) * Ch;
                Console.WriteLine("Q/2: " + Q / 2);
                Console.WriteLine("1 - d / p: " + (1 - d / p));
                Console.WriteLine("p: " + p);
                Console.WriteLine(result);
                lResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }

        }
    }
}
