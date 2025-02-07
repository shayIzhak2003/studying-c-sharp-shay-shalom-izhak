using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Intarface.my_first_app
{
    public interface IElectric
    {
        bool Is250V(); // return  true if the product is 250v and more.
        int ReturnVoltage(); // returnning the product voltage.
    }
}
