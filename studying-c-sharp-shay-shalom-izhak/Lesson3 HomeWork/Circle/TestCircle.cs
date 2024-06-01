using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Circle
{
    internal class TestCircle
    {
        public static void DemoMain()
        {
            // first constractor
            Circle c1 = new Circle();
            // We Using C4 Leter..
            Circle c4 = new Circle();
            Console.WriteLine($"the circle as radius of : {c1.GetRadius()}, and area of :" +
                $" {c1.GetArea()}, and color of : {c1.GetColor()}");

            // second constractor
            Circle c2 = new Circle(2.0);
            Console.WriteLine($"the circle as radius of : {c2.GetRadius()}, and area of :" +
                $" {c2.GetArea()}, and color of : {c2.GetColor()}");

            // third constractor
            Circle c3 = new Circle(2.0, "blue");
            Console.WriteLine($"the circle as radius of : {c3.GetRadius()}, and area of :" +
                $" {c3.GetArea()}, and color of : {c3.GetColor()}");

            // print after set
            c1.SetColor("green");
            c2.SetRadius(100);
            c3.SetRadius(30);
            c3.SetColor("yellow");


            Console.WriteLine("======================");

            // first constractor
            Console.WriteLine($"the circle as radius of : {c1.GetRadius()}, and area of :" +
                $" {c1.GetArea()}, and color of : {c1.GetColor()}");

            // second constractor
            Console.WriteLine($"the circle as radius of : {c2.GetRadius()}, and area of :" +
                $" {c2.GetArea()}, and color of : {c2.GetColor()}");

            // third constractor
            Console.WriteLine($"the circle as radius of : {c3.GetRadius()}, and area of :" +
                $" {c3.GetArea()}, and color of : {c3.GetColor()}");

            // Usag Of C4
            Console.WriteLine();
            c4.SetRadius(5.5);
            Console.WriteLine("radius is: " + c4.GetRadius()); 
            c4.SetColor("green");
            Console.WriteLine("color is: " + c4.GetColor());
            Console.WriteLine();

            // what not to do is :
            // You cannot do the following because setRadius() returns void, which cannot be printed!!!
            //Console.WriteLine(c4.SetRadius(4.4));

            // Using ToString() function :
            Console.WriteLine("Using ToString() function :");
            Console.WriteLine("======================");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c4.ToString());
            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("testing Circle2 Class :");
            Console.WriteLine();

            Circle2 c6 = new Circle2(1.1);
            Console.WriteLine(c6);  
            Circle2 c7 = new Circle2(); 
            Console.WriteLine(c7);

            // Test setter and getter
            c6.SetRadius(2.2);
            Console.WriteLine(c6);
            Console.WriteLine("radius is: " + c6.GetRadius());

            // Test getArea() and getCircumference()
            Console.WriteLine("area is: " +  Math.Abs(c6.GetArea()));
            Console.WriteLine("circumference is: " + Math.Abs(c6.GetCircumference(c6.GetRadius())));

        }
    }
}
