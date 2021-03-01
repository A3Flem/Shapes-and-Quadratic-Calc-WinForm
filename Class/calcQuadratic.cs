using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms;

namespace WinForms.Class
{
    class calcQuadratic
    {
        public static Tuple<string, string> getQuadratic(double a, double b, double c)
        {
            //Quadratic formula
            double sqrtpart = b * b - 4 * a * c;
            
            double x, x1, x2, img;
            Tuple<string, string> answer;

            if (sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                answer = new Tuple<string, string> ("Two Real: ", "(" + x1 +","+ x2 + ")");
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = Math.Sqrt(sqrtpart) / (2 * a);
                answer = new Tuple<string, string> ("Two Possible: ", "(" + img + "," + x + ")");
            }
            else
            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                answer = new Tuple<string, string> ("One Real: ", "(" + x + ")");
            }
            return answer;
        }
    }
}
