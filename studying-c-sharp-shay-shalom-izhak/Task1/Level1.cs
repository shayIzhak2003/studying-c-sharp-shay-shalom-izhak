using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.classes
{
    internal class Level1
    {
        //members = proporties
        public static string name = "Level1";
        //functions
        public static void RunProcess()
        {
            Console.WriteLine($"hi , i am class :{name}");
            Level2.RunProcess();
        }
    }
}
