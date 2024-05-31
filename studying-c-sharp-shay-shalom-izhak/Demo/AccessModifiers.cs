using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Demo
{
    public class AccessModifiers
    {
        public static void Demo()
        {
            MyDate myDate = new MyDate();
            myDate.SetMinute(34);
            myDate.DisplayTime();

            myDate.SetMinute(70);
            myDate.DisplayTime();

            Console.WriteLine("minute = "+ myDate.GetMinute());
        }
    }
    public class MyDate 
    {
        private int minute = 0;
        public int hour = 0;
        private string country;

        public void SetCountry(string country)
        {
            this.country = country;
        }
        

        public void SetMinute(int minute)
        {
            if(minute >=0 && minute <= 59)
            {
                this.minute = minute;
            }
        }

        public int GetMinute()
        {
            return this.minute;
        }
        public void DisplayTime()
        {
            Console.WriteLine($"{hour}-{minute}");
        }
    }

}
