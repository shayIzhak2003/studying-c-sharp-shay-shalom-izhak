using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Lesson10
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        VehicleType Type { get; set; }

        void DisplayInfo();
    }
}
