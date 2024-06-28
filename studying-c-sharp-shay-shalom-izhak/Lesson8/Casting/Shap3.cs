using studying_c_sharp_shay_shalom_izhak.Lesson7.Virtual___Ovveride;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson8.Casting
{
    // Base class for shapes
    public class Shape3
    {
        // Protected fields accessible by derived classes
        protected double height;
        protected double width;

        // Constructor
        public Shape3(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        // Properties for height and width
        public double Height
        {
            get => height;
            set => height = value;
        }
        public double Width
        {
            get => width;
            set => width = value;
        }

        // Virtual method for calculating area
        public virtual double CalculateArea()
        {
            return height * width;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Shape - Height = {Height}, Width = {Width}";
        }
    }

    // Rectangle class derived from Shape
    public class Rectangle : Shape3
    {
        public Rectangle(double height, double width) : base(height, width) { }

        public override string ToString()
        {
            return $"Rectangle - Height = {Height}, Width = {Width}, Area = {CalculateArea()}";
        }
    }

    // Circle class
    public class Circle : Shape3
    {
        // Circle has only a radius, we will use width as diameter
        public Circle(double radius) : base(radius, radius) { }

        // Override CalculateArea to compute circle area
        public override double CalculateArea()
        {
            double radius = Height; // In this context, height represents the radius
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle - Radius = {Height}, Area = {CalculateArea():F2}";
        }
    }

    // Triangle class derived from Shape
    public class Triangle : Shape3
    {
        public Triangle(double height, double width) : base(height, width) { }

        // Override CalculateArea for triangle
        public override double CalculateArea()
        {
            return 0.5 * Height * Width;
        }

        public override string ToString()
        {
            return $"Triangle - Height = {Height}, Width = {Width}, Area = {CalculateArea()}";
        }
    }

    // EquilateralTriangle class derived from Shape
    public class EquilateralTriangle : Shape3
    {
        public EquilateralTriangle(double side) : base(side, side) { }

        // Override CalculateArea for equilateral triangle
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Height * Height; // Height and Width represent side length
        }

        public override string ToString()
        {
            return $"Equilateral Triangle - Side = {Height}, Area = {CalculateArea():F2}";
        }
    }

    public class RunShap3 
    { 
        public static void DemoMain()
        {
            // Create shapes
            Shape3 rectangle = new Rectangle(10, 5);
            Shape3 circle = new Circle(7);
            Shape3 triangle = new Triangle(6, 8);
            Shape3 equilateralTriangle = new EquilateralTriangle(5);

            // Array of shapes
            Shape3[] shapes = { rectangle, circle, triangle, equilateralTriangle };

            // Print shapes and their areas
            foreach (Shape3 shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }

}
