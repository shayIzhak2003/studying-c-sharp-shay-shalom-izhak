using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public class Picture : Art, IStorable
    {
        public void Save()
        {
            Console.WriteLine("Saving picture...");     
        }

        public void Load()
        {
            Console.WriteLine("Loading picture...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Artist: {Artist}, Medium: {Medium}");
        }
    }

}
