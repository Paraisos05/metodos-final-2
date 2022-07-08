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
    public partial class InventarioPromedio : Form
    {
        public InventarioPromedio()
        {
            InitializeComponent();
        }

        private void InventarioPromedio_Load(object sender, EventArgs e)
        {

        }

        private void btInventarioProm_MouseClick(object sender, MouseEventArgs e)
        {

            double d;
            double Q;
            double p;
            double result;
            try
            {
                d = double.Parse(tbDemandaDiaria.Text);
                Q = double.Parse(tbPiezas.Text);
                p = double.Parse(tbProduccion.Text);
                result = (Q / 2) * (1 - d / p);
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

        private void btInventarioProm_Click(object sender, EventArgs e)
        {

        }
    }
}
