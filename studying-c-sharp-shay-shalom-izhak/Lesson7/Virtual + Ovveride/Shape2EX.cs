using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson7.Virtual___Ovveride
{
    public abstract class Shape2EX
    {
        // Abstract method to calculate area
        public abstract double CalculateArea();
    }
       
    public class Circel : Shape2EX
    {
        private double Radius;

        public double GetRadius() => this.Radius;
        public void SetRdius(double radius) => this.Radius = radius;

        public Circel(double radius) : base()
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.GetRadius(), 2);
        }
    }

    public class Triangle2 : Shape2EX 
    {
        private double Width;
        private double Height2;

        public double GetWidth() => this.Width;
        public double GetHeight() => this.Height2;


        public Triangle2(double width , double heigth2)
        {
            this.Width = width;
            this.Height2 = heigth2;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height2;
        }


    }

    public class RunShape2EX 
    {
        public static void DemoMain()
        {
            Shape2EX shape = new Triangle2(2,3);
            Shape2EX circle = new Circel(45);
            Console.WriteLine($"the area is : {shape.CalculateArea()}");
            Console.WriteLine($"the circle area is : {circle.CalculateArea()}");
        }
    }


}
