using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public class MensShoe : Shoe
    {
        public int Year { get; set; }
        public bool IsWorkShoe { get; set; }

        public MensShoe(string producer, int size, string color, int year, bool isWorkShoe)
            : base(producer, size, color, 200) // Base price for adult shoes
        {
            this.Year = year;
            this.IsWorkShoe = isWorkShoe;
        }

        public override decimal CalculatePrice()
        {
            decimal price = Size > 40 ? 300 : BasePrice;

            if (Year == 2023)
                price *= 1.5m; // 50% increase for shoes made in 2023

            if (IsWorkShoe)
                price -= 50; // Discount for work shoes

            return price;
        }
    }

}
