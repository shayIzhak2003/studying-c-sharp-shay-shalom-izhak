using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson11
{
    public class Wall
    {
        private List<IHangable> hangables = new List<IHangable>();

        public void AddHangable(IHangable hangable)
        {
            hangables.Add(hangable);
        }

        public void DisplayHangables()
        {
            foreach (var hangable in hangables)
            {
                hangable.Hang();
            }
        }
    }

}
