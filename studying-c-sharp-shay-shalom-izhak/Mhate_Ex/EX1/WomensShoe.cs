using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public class WomensShoe : Shoe
    {
        public int Year { get; set; }
        public int HeelHeight { get; set; }

        public WomensShoe(string producer, int size, string color, int year, int heelHeight)
            : base(producer, size, color, 200) // Base price for adult shoes
        {
            this.Year = year;
            this.HeelHeight = heelHeight;
        }

        public override decimal CalculatePrice()
        {
            decimal price = Size > 40 ? 300 : BasePrice;

            if (HeelHeight >= 3 && HeelHeight < 5)
                price += 30; // Additional price for heels >= 3 cm
            else if (HeelHeight >= 5)
                price += 60; // Additional price for heels >= 5 cm

            if (Year == 2023)
                price *= 1.5m; // 50% increase for shoes made in 2023

            return price;
        }
    }
}
