using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public abstract class Shoe
    {
        public string Producer { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public decimal BasePrice { get; protected set; }

        protected Shoe(string producer, int size, string color, decimal basePrice)
        {
            this.Producer = producer;
            this.Size = size;
            this.Color = color;
            this.BasePrice = basePrice;
        }

        public abstract decimal CalculatePrice();
    }

}
