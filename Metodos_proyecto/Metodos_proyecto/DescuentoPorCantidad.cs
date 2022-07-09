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
    public partial class DescuentoPorCantidad : Form
    {
        public DescuentoPorCantidad()
        {
            InitializeComponent();
        }

        private void DescuentoPorCantidad_Load(object sender, EventArgs e)
        {

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double D;
            double Co;
            double Ch;

            float Precio1;
            float Precio2;
            float Precio3;

            float Cantidad1;
            float Cantidad2;
            float Cantidad3;

            double EOQ1;
            double EOQ2;
            double EOQ3;

            double costoTotal1;
            double costoTotal2;
            double costoTotal3;

            try
            {

                D = double.Parse(tbDemandaAnual.Text);
                Co = double.Parse(tbCostoOrdenar.Text);
                Ch = double.Parse(tbCostoAlmacenar.Text);

                Precio1 = float.Parse(tbPrecio1.Text);
                Precio2 = float.Parse(tbPrecio2.Text);
                Precio3 = float.Parse(tbPrecio3.Text);

                Cantidad1 = float.Parse(tbCantidad1.Text);
                Cantidad2 = float.Parse(tbCantidad3.Text);
                Cantidad3 = float.Parse(tbCantidad5.Text);

                EOQ1 = Math.Sqrt((2 * D * Co) / (Ch * Precio1));
                EOQ2 = Math.Sqrt((2 * D * Co) / (Ch * Precio2));
                EOQ3 = Math.Sqrt((2 * D * Co) / (Ch * Precio3));

                if(EOQ1 < Cantidad1)
                {
                    EOQ1 = Cantidad1;
                }
                if (EOQ2 < Cantidad2)
                {
                    EOQ2 = Cantidad2;
                }
                if (EOQ3 < Cantidad3)
                {
                    EOQ3 = Cantidad3;
                }

                costoTotal1 = (D * Precio1) + ((D / EOQ1) * Co) + ((EOQ1 / 2) * Ch * Precio1);
                costoTotal2 = (D * Precio2) + ((D / EOQ2) * Co) + ((EOQ2 / 2) * Ch * Precio2);
                costoTotal3 = (D * Precio3) + ((D / EOQ3) * Co) + ((EOQ3 / 2) * Ch * Precio3);
                
                if(costoTotal1 < costoTotal2 && costoTotal1 < costoTotal3)
                {
                    //lResultado1.Text = costoTotal1.ToString();
                    lResultado2.Text = EOQ1.ToString();
                }
                else if (costoTotal2 < costoTotal1 && costoTotal2 < costoTotal3)
                {
                    //lResultado1.Text = costoTotal2.ToString();
                    lResultado2.Text = EOQ2.ToString();
                }
                else
                {
                    //lResultado1.Text = costoTotal3.ToString();
                    lResultado2.Text = EOQ3.ToString();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        private void lResultado2_Click(object sender, EventArgs e)
        {

        }
    }
}
