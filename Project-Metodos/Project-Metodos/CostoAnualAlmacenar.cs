using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Metodos
{
    public partial class CostoAnualAlmacenar : Form
    {
        public CostoAnualAlmacenar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Q;
            double Ch;
            try
            {

                Q = double.Parse(tbPiezas.Text);
                Ch = double.Parse(tbCostoAnualAlmacenar.Text);

                tbResult.Text = ((Q / 2) * Ch).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
    }
}
