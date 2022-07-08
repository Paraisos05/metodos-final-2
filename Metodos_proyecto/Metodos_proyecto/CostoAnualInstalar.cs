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
    public partial class CostoAnualInstalar : Form
    {
        public CostoAnualInstalar()
        {
            InitializeComponent();
        }

        private void bCostoAnual_Click(object sender, EventArgs e)
        {

            double D;
            double Q;
            double Cs;
            double result;
            try
            {
                D = double.Parse(tbDemandaAnual.Text);
                Q = double.Parse(tbPiezasOrdenar.Text);
                Cs = double.Parse(tbCostoPreparar.Text);
                result = (D / Q) * Cs;

                lResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void CostoAnualInstalar_Load(object sender, EventArgs e)
        {

        }
    }
}
