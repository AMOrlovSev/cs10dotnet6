using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exercise02
{
    public abstract class Shape
    {
        protected double height;
        protected double width;
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return Height* Width;
            }
        }   
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }

    public class Square : Rectangle
    {
        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
        public Square(double side) : base(side, side)
        {
            Height = side;
            Width = side;
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override double Area
        {
            get
            {
                return System.Math.PI*System.Math.Pow(Radius,2);
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
            Height = 2* radius;
            Width = 2 * radius;
        }
    }
}
