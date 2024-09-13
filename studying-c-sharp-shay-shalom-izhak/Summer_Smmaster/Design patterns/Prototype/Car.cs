using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Prototype
{
    public class Car : ICloneable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        // Implementing Clone method
        public object Clone()
        {
            // MemberwiseClone creates a shallow copy. Modify as needed for deep copy if necessary.
            //return (Car)MemberwiseClone();
            // deep clone: 
            return new Car(this.Make, this.Model, this.Year, this.Color);
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} in {Color}";
        }
    }
}
