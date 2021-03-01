using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Class;
using NUnit.Framework;

namespace WinForms.Test
{
    class testTriangle
    {
        [Test]
        public void TestgetTriangleArea()
        {
            double a = 2.0;
            double b = 3.0;
            double c = 4.0;
            Assert.AreEqual(2.9047, Math.Round(calcTriangle.getTriangleArea(a,b,c)), 4);
        }
        [Test]
        public void TestgetTrianglePeri()
        {
            double a = 2.0;
            double b = 4.0;
            double c = 6.0;
            Assert.AreEqual(24.0, calcTriangle.getTrianglePeri(a,b,c));
        }
    }
}