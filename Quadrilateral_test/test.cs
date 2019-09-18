using System;
using NUnit.Framework;
using Shapes;
// remember to reference and import your shape library

namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }

        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }

        Square sq3 { get; set; }
        Rectangle rec3 { get; set; }


        [SetUp]
        public void Init()
        {
            sq1 = new Square("Blue", 5);
            rec1 = new Rectangle("Red", 5, 10);

            sq2 = new Square("Blue", 15);
            rec2 = new Rectangle("Red", 4, 6);

            sq3 = new Square("Blue", 7);
            rec3 = new Rectangle("Red", 9, 7);

        }

        [Test]
        public void SquareTests()
        {
            int area = 25;
            int perimeter = 20;

            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, sq3.GetArea());
            Assert.AreEqual(perimeter, sq3.GetPerimeter());

        }

        [Test]
        public void RectangleTests()
        {
            int area = 50;
            int perimeter = 30;

            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, rec3.GetArea());
            Assert.AreEqual(perimeter, rec3.GetPerimeter());
        }
    }
}