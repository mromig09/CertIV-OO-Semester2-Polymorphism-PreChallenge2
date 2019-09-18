using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral
    {
        public string Color;
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;

        public Quadrilateral(string color, int side1length, int side2length, int side3length, int side4length)
        {
            Color = color;
            Side1Length = side1length;
            Side2Length = side2length;
            Side3Length = side3length;
            Side4Length = side4length;
        }

        public int GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }

    }

    public class Square : Quadrilateral
    {


        public Square(string color, int SideLength) : base(color, SideLength, SideLength, SideLength, SideLength)
        {
            Color = color;
        }
        public int GetArea()
        {
            return Side1Length * Side1Length;
        }

    }

    public class Rectangle : Quadrilateral
    {


        public Rectangle(string color, int SideLength, int Side2Length) : base(color, SideLength, Side2Length, SideLength, Side2Length)
        {
            Color = color;
        }

        public int GetArea()
        {
            return Side1Length * Side2Length;
        }
    }

    public abstract class Triangle
    {
        public string Color;
        public float Side1Length;
        public float Side2Length;
        public float Side3Length;

        public Triangle(string color, float side1length, float side2length, float side3length)
        {
            Color = color;
            Side1Length = side1length;
            Side2Length = side2length;
            Side3Length = side3length;
        }

        public float GetPerimeter()
        {
            return (float)(Side1Length + Side2Length + Side3Length);
        }
    }

    public class RightAngleTriangle : Triangle
    {


        public RightAngleTriangle(string color, float side1length, float side2length) :
                base(color, side1length, side2length, (float)Math.Sqrt(side1length * side1length + side2length * side2length))
        {
            Color = color;
        }

        public float GetArea()
        {
            return (float)(0.5 * Side1Length * Side2Length);
        }
    }

    public class EquilateralTriangle : Triangle
    {

        public EquilateralTriangle(string color, float side1length) :
            base(color, side1length, side1length, side1length)
        {
            Color = color;
        }

        public float GetArea()
        {
            return (float)((Math.Sqrt(3) / 4) * (Side1Length * Side1Length));
        }
    }

    public class Circle
    {
        public string Color;
        public int Radius;
        public double PI = Math.PI;

        public Circle(string color, int radius, double pi)
        {
            Color = color;
            Radius = radius;
            PI = pi;
        }
        public double GetPerimeter()
        {
            return Math.Round((2 * PI * Radius), 2);
        }

        public double GetArea()
        {
            return Math.Round(PI * (Radius * Radius), 2);
            //2nd decimal to the nearest 5th
            //return PI * (Radius * Radius);
        }

    }
}