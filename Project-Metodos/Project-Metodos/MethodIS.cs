using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Metodos
{
    class Desviation {
        public int Level { get; set; }
        public double Value { get; set; }

        public Desviation(int level, double value) {
            this.Level = level;
            this.Value = value;
        }

    }
   
    class MethodIS
    {
        List<Desviation> desviations;
        public MethodIS() {
            desviations = new List<Desviation>();
            desviations.Add(new Desviation(90,1.28));
            desviations.Add(new Desviation(91, 1.34));
            desviations.Add(new Desviation(92, 1.41));
            desviations.Add(new Desviation(93, 1.48));
            desviations.Add(new Desviation(94, 1.55));
            desviations.Add(new Desviation(95, 1.65));
            desviations.Add(new Desviation(96, 1.75));
            desviations.Add(new Desviation(97, 1.88));
            desviations.Add(new Desviation(98, 2.05));
            desviations.Add(new Desviation(99, 2.33));
        }
        //D-Demanda promedio
        //desv-#desviaciones
        //alpha-desviacion estandar
        public string IS_desviaciones(int D,double desv,int alpha) {
            double z = getZpercent(desv);
            var ROP = D+z*alpha;//punto reorden
            var IS = Math.Abs(D-ROP);//Inventario seguridad

            return "ROP = "+Math.Ceiling(ROP)+",IS = "+ Math.Ceiling(IS);
        }
        //D-Demanda promedio
        //desv-#desviaciones
        //alpha-desviacion estandar
        public string IS_nivelServicio(int D, double desv, double alpha) {
            double z = getZ(desv); 
            var ROP = getROP( D, z, alpha);//punto reorden
            var IS = getIS(D,ROP);//Inventario seguridad

            return "ROP = " + Math.Ceiling(ROP) + ",IS = " + Math.Ceiling(IS);
        }
        //D-Demanda promedio
        //desv-#desviaciones
        //alpha-desviacion estandar
        public double getROP(int D,double z, double alpha) {
            return D + z * alpha;
        }

        public double getIS(int D, double rop) {
            return Math.Abs(D - rop);
        }
        public double getZ(double desv){
            double z = 0;
            if (desv == 99.99)
            {
                z = 3.71;
            }
            else
            {
                var dtoi = Convert.ToInt32(desv);
                var item = desviations.Find(x => x.Level == dtoi);
                z = item.Value;
            }
            return z;
        }
        public double getZpercent(double desv)
        {
            double des = 100 - desv;
            double z = 0;
            if (des == 99.99)
            {
                z = 3.71;
            }
            else
            {
                var dtoi = Convert.ToInt32(des);
                var item = desviations.Find(x => x.Level == dtoi);
                z = item.Value;
            }
            return z;
        }

        //CTA-costo total anual
        //D-Demanda anual
        //Ch-costo por almacenar unidad por año
        //Co-costo de pedido
        public string IS_CostoTotalAnual(double D,double Ch,double Co)
        {
            double Q = Math.Sqrt((2*D*Co)/Ch);//numero optimo de unidades por pedido
            double CTA = ((D / Q) * Co) + ((Q / 2) * Ch);//costo total anual
            double nPA = D / Q;//numero de pedidos anual
            double IP = Q / 2;//inventario promedio anual
            return "Q = "+ Math.Ceiling(Q) + ",CTA = " + Math.Ceiling(CTA)+",PA = "+ Math.Ceiling(nPA)+", IP = "+ Math.Ceiling(IP); 
        }
    }
}
