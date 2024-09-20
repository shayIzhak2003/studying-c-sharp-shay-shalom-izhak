using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Summer_Smmaster.Design_patterns.Builder.real_estate_app
{
    public class House
    {
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"House at {Address} with {Bedrooms} bedrooms, {Bathrooms} bathrooms, " +
                   $"{(HasGarage ? "a garage, " : "")}{(HasGarden ? "a garden, " : "")}" +
                   $"{(HasSwimmingPool ? "a swimming pool, " : "")}.";
        }
    }

}
