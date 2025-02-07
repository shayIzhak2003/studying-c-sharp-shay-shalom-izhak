using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Intarface.my_first_app
{
    public class Elctronics : IElectric
    {
        public static int publicId = 0;

        public int id = publicId++;
        public string name { get; set; }
        public int voltage { get; set; }

        public Elctronics(string name, int voltage)
        {
            this.name = name;
            this.voltage = voltage;
            this.id = publicId;
        }

        public override string ToString()
        {
            return $"the id is :=> {this.id}, the name is :=> {this.name}, the voltage => {this.voltage}";
        }

        public virtual bool Is250V()
        {
            return this.voltage >= 250;
        }
        public virtual int ReturnVoltage()
        {
            return this.voltage;
        }
    }
}
