using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Ran_Object_Oriented.Intarface.my_first_app
{
    public class Tv : Elctronics
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string resolution {  get; set; }

        public Tv(string name,int voltage, int height, int width, string resolution)
            :base(name, voltage)
        {
            this.Height = height;
            this.Width = width;
            this.resolution = resolution;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, the height is => {this.Height} the width is => {this.Width}" +
                $"the resolution is => {this.resolution}";
        }

        public override bool Is250V()
        {
            return this.Height <=12 && this.Width <=12 && this.voltage>=250 ? true : false;
        }
        public override int ReturnVoltage()
        {
            return this.Height >=4 && this.Width>=4 ? this.voltage : this.voltage - this.voltage;
        }
    }
}
