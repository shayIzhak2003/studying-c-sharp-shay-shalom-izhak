using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public class Painting : IHangable
    {
        public void Hang()
        {
            Console.WriteLine("Hanging painting...");
        }
    }
}
