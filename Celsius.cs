using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_TemperatureConversion
{
    public class Celsius
    {
        private double cels1;
        private double cels2;
        public Celsius(double cels1)
        {

            this.cels1 = cels1;
            

        }
        public double Getcels1()
        {
            return cels1;
        }
        public void Setcels1(double cels1)
        {
            this.cels1 = cels1;
        }
        public double Getcels2()
        {
            return cels2;
        }
        public void Setcels2(double cels2)
        {
            this.cels2 = cels2;
        }

        public void ConvertC2F()
        {
            double c1;
            c1 = cels1;
            cels2 = c1 * 8 + 32;


        }
    }
}