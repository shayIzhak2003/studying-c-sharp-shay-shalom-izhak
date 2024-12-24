using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.EX1
{
    public class Storage
    {
        private List<Shoe> Shoes { get; set; }

        public Storage()
        {
            this.Shoes = new List<Shoe>();
        }

        public void AddShoe(Shoe shoe)
        {
            Shoes.Add(shoe);
        }

        public int CalcOrthopedicCount()
        {
            int count = 0;
            foreach (var shoe in Shoes)
            {
                if (shoe is KidsShoe kidsShoe && kidsShoe.IsOrthopedic)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
