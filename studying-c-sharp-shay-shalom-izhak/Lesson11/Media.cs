using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public abstract class Media
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public abstract void DisplayInfo();
    }

}
