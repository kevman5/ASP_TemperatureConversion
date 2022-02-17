using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_TemperatureConversion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Convert_Click(object sender, EventArgs e)
        {
            Celsius C1;
            double cels1;
            cels1 = double.Parse(tb_c1.Text);
           

            C1 = new Celsius(cels1);
            C1.ConvertC2F();
            
            tb_fhnt1.Text = C1.Getcels2().ToString();


        }

        protected void Convert2_Click(object sender, EventArgs e)
        {
            Fahrenheit F1;
            double fhnt1;
            fhnt1 = double.Parse(tb_fhnt1.Text);
           

            F1 = new Fahrenheit(fhnt1);
            F1.ConvertF2C();
            tb_c1.Text = F1.getfhnt2().ToString();
            


        }


    }
}