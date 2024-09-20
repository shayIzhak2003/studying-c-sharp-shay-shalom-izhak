using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.Product_Manngement_app
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Manufacturer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Manufacturer: [Name = {Name}, Address = {Address}]";
        }
    }

}
