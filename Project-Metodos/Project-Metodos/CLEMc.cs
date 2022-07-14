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
    public partial class CLEMc : Form
    {
        public CLEMc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int d = 0;
            double Co = 0;
            double Ch = 0;
            try
            {
                d = int.Parse(tbDemandaAnual.Text);
                Co = double.Parse(tbCostoOrden.Text);
                Ch = double.Parse(tbCostoAnualAlmacenar.Text);

                lRespuesta.Text = Math.Sqrt((2 * d * Co) / Ch).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
