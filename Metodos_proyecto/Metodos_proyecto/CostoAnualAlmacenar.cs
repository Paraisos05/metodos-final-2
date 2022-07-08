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
    public partial class CostoAnualAlmacenar : Form
    {
        public CostoAnualAlmacenar()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {

            double Q;
            double Ch;
            try
            {

                Q = double.Parse(tbPiezas.Text);
                Ch = double.Parse(tbCostoAnualAlmacenar.Text);

                lResult.Text = ((Q / 2) * Ch).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void lResult_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CostoAnualAlmacenar_Load(object sender, EventArgs e)
        {

        }
    }
}
