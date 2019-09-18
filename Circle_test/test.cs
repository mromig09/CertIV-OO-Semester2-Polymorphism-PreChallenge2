using System;
using NUnit.Framework;
using Shapes;

namespace Circle_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("blue", 5, Math.PI, 31.42)]
        
        public void Get_perimeter_circle(string input, int radius, double pi, double expected)
        {
            var s = new Circle(input, radius, pi);
            double result = s.GetPerimeter();
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("blue", 5, Math.PI, 78.55)]

        public void Get_area_circle(string input, int radius, double pi, double expected)
        {
            var s = new Circle(input, radius, pi);
            double result = s.GetArea();
            Assert.AreEqual(Math.Round(expected, 2), result);
        }


    }
}
