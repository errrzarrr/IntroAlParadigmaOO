using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Pilot : Driver
    {
        private double _salary;
        private int _maxDrivingSpeed = 0;

        public Pilot() { }

        public Pilot(Driver driver) : base(driver)
        {
            Console.WriteLine("Please indicate your max driving speed");
            this.SetMaxDrivingSpeed(int.Parse(Console.ReadLine()));
        }

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

        public void SetMaxDrivingSpeed(int maxDrivingSpeed)
        {
            if (maxDrivingSpeed < 150)
            {
                Console.WriteLine($"Driving at {maxDrivingSpeed} km/h is too slow for a good pilot");
            }
            else this._maxDrivingSpeed = maxDrivingSpeed;
        }
        public double GetMaxDrivingSpeep()
        {
            return this._maxDrivingSpeed;
        }

        public override void ObtainDriverLicense()
        {
            int age = DateTime.Today.Year - this.GetDateOfBirth().Year;
                        
            if (age < 22)
            {
                Console.WriteLine("You are not old enough to get a pilot driver's license");
            } else this._licenseId = $"Pro-{this.GetName()}{this.GetDateOfBirth().Year}{this.GetDateOfBirth().Month}{this.GetDateOfBirth().Day}";
        }
    }
}
