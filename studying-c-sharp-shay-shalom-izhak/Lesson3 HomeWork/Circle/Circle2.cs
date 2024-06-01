using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson3_HomeWork.Circle
{
    internal class Circle2
    {
        private double radius;

        public Circle2()
        {
            this.radius = 1.0;
         
        }


        public Circle2(double r)
        {
            this.radius = r;
           
        }

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

        public override string ToString()
        {
            return "Circle[radius = " + this.radius +"]";
        }

        public double GetCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }


    }
}
