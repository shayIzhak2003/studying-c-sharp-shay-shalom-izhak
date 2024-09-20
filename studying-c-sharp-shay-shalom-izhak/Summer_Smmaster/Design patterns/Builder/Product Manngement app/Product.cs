using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class Product
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
        public double WeightPerUnit { get; set; }

        public override string ToString()
        {
            return $"Product: [Name = {Name}, Barcode = {Barcode}, Price = {Price} {Unit}, Weight = {WeightPerUnit} g per 100g]";
        }
    }


}
