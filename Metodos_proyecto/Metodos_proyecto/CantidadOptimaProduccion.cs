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
    public partial class CantidadOptimaProduccion : Form
    {
        public CantidadOptimaProduccion()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double d = 0;
            double D;
            double Cs = 0;
            double Ch = 0;
            double p;
            try
            {
                d = double.Parse(tbDemandaDiaria.Text);
                D = double.Parse(tbDemandaAnual.Text);
                Cs = double.Parse(tbCostoPreparar.Text);
                Ch = double.Parse(tbCostoAnualAlmacenar.Text);
                p = double.Parse(tbProduccion.Text);

                lResult.Text = Math.Sqrt((2 * Cs * D) / (Ch * (1 - d / p))).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void CantidadOptimaProduccion_Load(object sender, EventArgs e)
        {

        }
    }
}
