using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms;

namespace WinForms.Class
{
    class calcTriangle
    {
        //Triangle methods
        public static double getTriangleArea(double a, double b, double c)
        {
            double s, area;
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        public static double getTrianglePeri(double a, double b, double c)
        {
            return (a + b + c) * 2;
        }
    }
}
