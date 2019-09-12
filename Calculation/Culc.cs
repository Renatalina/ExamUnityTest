using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public  class Culc
    {
        public Culc() {   }
        public double CulcRadian(double degree)
        {
            double radian = degree * 0.01745;
            return radian;
        }

        public int CulcDegree(double radian)
        {
            int degree =(int) (radian / 0.01745);            
            return degree;
        }

        public double CulcMill(int km)
        {
            double mille = km / 1.609;
            return mille;
        }

        public int CulcKM(double mille)
        {
            int km =(int) (mille*1.609);
            return km;
        }
    }
}
