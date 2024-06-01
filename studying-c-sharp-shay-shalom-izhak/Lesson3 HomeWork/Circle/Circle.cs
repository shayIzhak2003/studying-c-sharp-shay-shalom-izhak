using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Circle
{
    public class Circle
    {

        private double radius;
        private string color;


        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }


        public Circle(double r)
        {
            this.radius = r;
            this.color = "red";
        }

        public Circle(double r, string color)
        {
            this.color = color;
            this.radius = r;
        }


        //get/set color/radius
        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double newRadius)
        {
            this.radius = newRadius;
        }
   


        public double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }
       

        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string newColor)
        {
            this.color = newColor;
        }

        public override string ToString()
        {
            return "Circle[radius = " + this.radius + " color=" + this.color + "]";
        }
    }
  


}
