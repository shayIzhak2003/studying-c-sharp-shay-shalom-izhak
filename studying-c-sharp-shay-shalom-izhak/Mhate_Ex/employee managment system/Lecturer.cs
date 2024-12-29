using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Mhate_Ex.employee_managment_system
{
    public class Lecturer : Employe
    {
        public string specialization;

       
        public Lecturer(string specialization, string name) : base(name)
        {
            this.specialization = specialization;
        }

        // Getter for specialization
        public string GetSpecialization()
        {
            return specialization;
        }

        // Setter for specialization
        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }
    }
}
