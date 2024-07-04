using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Trensportaion_app
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}, Age: {age}, ID: {id}";
        }
    }

}
