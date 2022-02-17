using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_TemperatureConversion
{
    public class Fahrenheit
    {
        private double fhnt1;
        private double fhnt2;

        public Fahrenheit(double fhnt1)
        {

            this.fhnt1 = fhnt1;


        }
        public double getfhnt1()
        {
            return fhnt1;
        }
        public void setfhnt1(double fhnt1)
        {
            this.fhnt1 = fhnt1;
        }
        public double getfhnt2()
        {
            return fhnt2;
        }
        public void setfhnt2(double fhnt2)
        {
            this.fhnt2 = fhnt2;
        }
        public void ConvertF2C()
        {
            double f1;
            f1 = fhnt1;
            fhnt2 = f1 - 32 / 1.8;


        }
    }
}