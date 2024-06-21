using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7.Virtual___Ovveride
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method to calculate area
        public abstract double CalculateArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override method to calculate area of circle
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Override method to calculate area of rectangle
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Derived class Triangle
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        // Constructor
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        // Override method to calculate area of triangle
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class RunShape
    {
        public static void RunDeom()
        {
            // Creating instances of different shapes
            Shape shape1 = new Circle(5);
            Shape shape2 = new Rectangle(3, 4);
            Shape shape3 = new Triangle(6, 8);

            // Calculating and displaying areas
            Console.WriteLine($"Area of Circle: {shape1.CalculateArea()}");       // Outputs: Area of Circle: 78.53981633974483
            Console.WriteLine($"Area of Rectangle: {shape2.CalculateArea()}");    // Outputs: Area of Rectangle: 12
            Console.WriteLine($"Area of Triangle: {shape3.CalculateArea()}");     // Outputs: Area of Triangle: 24
            Console.ReadLine();
        }
    }

}
