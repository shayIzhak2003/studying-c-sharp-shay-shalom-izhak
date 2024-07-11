using studying_c_sharp_shay_shalom_izhak.Trensportaion_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shay_shalom_izhak.Transportation_app
{
    public class DriverInfo : Person
    {
        public double seniority { get; set; }
        public double hours { get; set; }
        public double MoneyPerHour { get; set; }
        public double salary { get; set; }
        public DriverInfo[] driverInfosArr { get; set; }

        // Constructor initializing properties
        public DriverInfo(double seniority, double hours, DriverInfo[] driverInfosArr)
        {
            this.seniority = seniority;
            this.hours = hours;
            this.driverInfosArr = driverInfosArr;
            this.CalculateMoneyPerHour(); // Calculate and set MoneyPerHour
        }
        
        // Calculate MoneyPerHour based on seniority
        public void CalculateMoneyPerHour()
        {
            if (this.seniority > 6)
            {
                this.MoneyPerHour = 100;
            }
            else
            {
                this.MoneyPerHour = 83;
            }
        }

        // Calculate salary based on hours and MoneyPerHour
        public double CalculateSalaryForDriver()
        {
            double res = this.hours * this.MoneyPerHour;
            return res;
        }

        // get most paid driver
        public DriverInfo GetMostPaidDriver(DriverInfo[] driversArr)
        {
            if (driversArr == null || driversArr.Length == 0)
            {
                return null; // Handle empty or null array
            }

            DriverInfo mostPaidDriver = driversArr[0];

            foreach (DriverInfo driver in driversArr)
            {
                if (driver.salary > mostPaidDriver.salary)
                {
                    mostPaidDriver = driver;
                }
            }

            // Print details of the most paid driver (optional)
            Console.WriteLine($"The driver with the highest salary is {mostPaidDriver.firstName} {mostPaidDriver.lastName}, with a salary of: {mostPaidDriver.salary}");

            return mostPaidDriver;
        }

        // Override ToString to include new properties
        public override string ToString()
        {
            string driverDetails = $"Seniority: {seniority}, Hours: {hours}, MoneyPerHour: {MoneyPerHour}, Salary: {salary}";
            string personDetails = base.ToString();
            string arrayDetails = "";

            if (driverInfosArr != null && driverInfosArr.Length > 0)
            {
                arrayDetails = "\nDrivers Array:\n";
                foreach (var driver in driverInfosArr)
                {
                    arrayDetails += driver.ToString() + "\n";
                }
            }

            return $"{personDetails}, {driverDetails}{arrayDetails}";
        }
    }
}
