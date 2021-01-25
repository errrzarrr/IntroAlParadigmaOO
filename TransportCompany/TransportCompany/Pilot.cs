using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    public class Pilot : Driver
    {
        private double salary;
        private int maxDrivingSpeed;

        public void SetSalary(double salary)
        {
            if (salary < 1000000)
            {
                Console.WriteLine($"${salary} is too little for me");
            }
            else this.salary = salary;
        }
        public double GetSalary()
        {
            return this.salary;
        }

        public override void SetLicense(string licenseId)
        {
            if (this.age < 22)
            {
                Console.WriteLine("You are not old enough to get a pilot driver's license");
            } else if (!CanDriveAtHighSpeed())
            {
                Console.WriteLine("You are not fast enough");
            } 
            else if ((licenseId == null) || (licenseId.Substring(0, 4) != "Pro-"))
            {
                Console.WriteLine("This is not a valid Pilot's driver license ID");
            }
            else this.licenseId = licenseId;
        }

        public void SetMaxDrivingSpeed(int maxDrivingSpeed)
        {
            if (maxDrivingSpeed < 150)
            {
                Console.WriteLine($"Driving at {maxDrivingSpeed} km/h is too slow for a good pilot");
            }
            else this.maxDrivingSpeed = maxDrivingSpeed;
        }
        public double GetMaxDrivingSpeep()
        {
            return this.maxDrivingSpeed;
        }

        private bool CanDriveAtHighSpeed()
        {
            return (this.maxDrivingSpeed < 150) ? false : true;
        }

        public override string ObtainDriverLicense()
        {
            this.SetLicense($"Pro-{this.GetName()}{this.GetDateOfBirth().Year}{this.GetDateOfBirth().Month}{this.GetDateOfBirth().Day}");

            return this.licenseId;
        }
    }
}
