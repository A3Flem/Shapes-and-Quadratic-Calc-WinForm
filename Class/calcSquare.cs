using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms;

namespace WinForms.Class
{
    class calcSquare 
    {
        //Rectangle methods
        public static double getRectangleArea(double height, double width)
        {
            return height * width;
        }
        public static double getRectanglePeri(double height, double width)
        {
            return (height + width) * 2;
        }
    }
}
