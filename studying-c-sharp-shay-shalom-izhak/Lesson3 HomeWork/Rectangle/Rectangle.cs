using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Rectangle
{
    public class Rectangle
    {
        #region

        private float width = 1.0f;
        private float height = 1.0f;

        public Rectangle()
        {
            this.width = 1.0f;
            this.height = 1.0f;
        }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        // Hegiht/Width : get/set functions()
        public float GetWidth()
        {
            return this.width;
        }
        public float GetHeight(float height)
        {
            return this.height;
        }
        public void SetWidth(float width)
        {
            this.width = width;
        }
        public void SetHeigth(float Heigth)
        {
            this.height = Heigth;
        }
        public override string ToString()
        {
            return $"the Rectangle paremeters are : [width : {this.width}, heigth : {this.height}]";
        }


        public float GetArea()
        {
            return this.width * this.height;
        }


        public float GetPerimeter()
        {
            return 2 * (this.width + this.height);
        }

        public static List<Rectangle> GetListOfRectangles(List<Rectangle> rectangles)
        {
            for(int i = 0; i < rectangles.Count; i++)
            {
                Console.WriteLine($"the value in the {i + 1} i" + rectangles[i]);
            }

            return rectangles;
        }
        public static float GetTotalArea(List<Rectangle> rectangles)
        {
            float totalArea = 0;
            foreach (Rectangle rectangle in rectangles)
            {
                totalArea += rectangle.GetArea();
            }
            return totalArea;
        }
        public static float GetTheBiggestArea(List<Rectangle> rectangles)
        {
            float theBiggestArea = 0;
            foreach(Rectangle rectangle in rectangles)
            {
                if(rectangle.GetArea() > theBiggestArea)
                {
                    theBiggestArea = rectangle.GetArea();
                }
            }
            return theBiggestArea;
        }




        #endregion
    }

    public class TestRectangle
    {
        #region

        public static void RunRectangle()
        {
            // Create a list of rectangles
            List<Rectangle> rectangles = new List<Rectangle>
            {
                new Rectangle(),
                new Rectangle(1.2f, 3.4f),
                new Rectangle(12f, 34f),
                new Rectangle(12.3f, 34.2f)
            };

            Console.WriteLine("Print all rectangles:");
            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine(rectangle.ToString());
            }

            Console.WriteLine("\nPrinting the areas:");
            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine($"{rectangle.ToString()}: Area = {rectangle.GetArea()}");
            }

            Console.WriteLine($"\nThe Biggest Rectangle Area is: = {Rectangle.GetTheBiggestArea(rectangles)}");

            Console.WriteLine($"the sum of all the rectangles area`s are : = {Rectangle.GetTotalArea(rectangles)}");
        }
        #endregion
    }
}
