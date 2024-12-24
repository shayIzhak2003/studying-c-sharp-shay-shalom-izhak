using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public class KidsShoe : Shoe
    {
        public bool IsOrthopedic { get; set; }

        public KidsShoe(string producer, int size, string color, bool isOrthopedic)
            : base(producer, size, color, 100) // Base price for kids' shoes
        {
            this.IsOrthopedic = isOrthopedic;
        }

        public override decimal CalculatePrice()
        {
            decimal price = BasePrice;
            if (Size > 40)
                price = 300; // Price for size > 40
            if (IsOrthopedic)
                price += 25; // Additional price for orthopedic shoes
            return price;
        }
     }
    }
