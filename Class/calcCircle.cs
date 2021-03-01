using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms;


namespace WinForms.Class
{
    class calcCircle
    {
        //Circle methods
        public static double getCircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);

        }
        public static double getCirclePeri(double r)
        {
            return Math.PI * r * 2;
        }
    }
}
