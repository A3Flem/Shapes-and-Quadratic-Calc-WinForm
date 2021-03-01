using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Class;
using NUnit.Framework;

namespace WinForms.Test
{
    class testQuadratic
    {
        [Test]
        public void TestgetQuadratic1()
        {
            double a = 1;
            double b = 2;
            double c = 5;

            Assert.AreEqual("(2,-1)", calcQuadratic.getQuadratic(a,b,c).Item2);
        }

        [Test]
        public void TestgetQuadratic2()
        {
            double a = 4;
            double b = 10;
            double c = -6;

            Assert.AreEqual("(0.5,-3)", calcQuadratic.getQuadratic(a,b,c).Item2);
        }

        [Test]
        public void TestgetQuadratic3()
        {
            double a = -5;
            double b = 5;
            double c = 0;

            Assert.AreEqual("(0,1)", calcQuadratic.getQuadratic(a,b,c).Item2);
        }

        //Test to show it will fail too
        [Test]
        public void TestgetQuadratic4()
        {
            double a = 1;
            double b = 2;
            double c = -3;

            Assert.AreEqual("(0,-1)", calcQuadratic.getQuadratic(a, b, c).Item2);
        }
    }
}
