using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class Employe
    {
        public string name;
        private int id;
        private static int publicId = 0;

        public Employe(string name)
        {
            this.name = name;
            this.id = ++publicId;
        }

        // Getter for name
        public string GetName()
        {
            return name;
        }

        // Setter for name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Getter for id
        public int GetId()
        {
            return id;
        }

        // Setter for id
        public void SetId(int id)
        {
            this.id = id;
        }

        // Getter for publicId (Static field)
        public static int GetPublicId()
        {
            return publicId;
        }

        // Setter for publicId (Static field)
        public static void SetPublicId(int newPublicId)
        {
            publicId = newPublicId;
        }

        public override string ToString()
        {
            return $"name : {this.GetName()}, id : {this.GetId()}";
        }
    }
}
