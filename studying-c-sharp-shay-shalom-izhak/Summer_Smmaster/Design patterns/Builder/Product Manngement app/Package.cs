using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class Package
    {
        public string Material { get; set; }
        public double Weight { get; set; } // In kilograms or pounds
        public string Dimensions { get; set; } // Example: "10x15x20 cm"

        public Package(string material, double weight, string dimensions)
        {
            Material = material;
            Weight = weight;
            Dimensions = dimensions;
        }

        public override string ToString()
        {
            return $"Package: [Material = {Material}, Weight = {Weight} kg, Dimensions = {Dimensions}]";
        }
    }

}
