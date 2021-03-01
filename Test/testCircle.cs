using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Class;
using NUnit.Framework;

namespace WinForms.Test
{
    class testCircle
    {
        [Test]
        public void TestgetCircleArea()
        {
            double r = 1.0;
            Assert.AreEqual(Math.PI, calcCircle.getCircleArea(r));
        }
        [Test]
        public void TestgetCirclePeri()
        {
            double r = 5.0;
            Assert.AreEqual(2* Math.PI* r, calcCircle.getCirclePeri(r));
        }
    }
}
