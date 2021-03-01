using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Class;
using NUnit.Framework;

namespace WinForms.Test
{
    [TestFixture]
    class testSquare
    {
        [Test]
        public void TestgetReactangleArea()
        {
            double height = 9.0;
            double width = 9.0;
            Assert.AreEqual(81.0, calcSquare.getRectangleArea(height, width));
        }
        [Test]
        public void TestgetRectanglePeri()
        {
            double height = 2.0;
            double width = 2.0;
            Assert.AreEqual(8.0, calcSquare.getRectanglePeri(height, width));
        }
    }
}
