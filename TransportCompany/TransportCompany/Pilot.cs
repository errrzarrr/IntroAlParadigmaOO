using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Pilot : Driver
    {
        private double _salary;

        public void SetSalary(double salary)
        {
            if (salary < 1000000)
            {
                Console.WriteLine($"${salary} is too little for me");
            }
            else this._salary = salary;
        }
        public double GetSalary()
        {
            return this._salary;
        }
    }
}
