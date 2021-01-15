using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Driver : Person, IDriver
    {
        protected string _licenseId;
        protected Vehicle _vehicle;

        public void DriveVehicle()
        {
            Console.WriteLine("Driving...");
        }

        public void SetLicense(string licenseId)
        {
            if(licenseId == "")
            {
                Console.WriteLine("Please enter a valid driver's license ID"); 
            } else this._licenseId = licenseId;
        }
        public string GetLicense()
        {
            return this._licenseId;
        }

        public void SetVehicle(Vehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public Vehicle GetVehicle()
        {
            return this._vehicle;
        }

        //TODO Method logic pending
        private bool CanDriveThisVehicle()
        {
            this._vehicle.GetType();
            return true;
        }

        public void ObtainDriverLicense(Person person)
        {
            int age = DateTime.Today.Year - person.GetDateOfBirth().Year;

            if (age < 15)
            {
                Console.WriteLine("You are not old enough to get a driver's license");
            }
            else this._licenseId = $"{person.GetName()}{person.GetDateOfBirth().Year}{person.GetDateOfBirth().Month}{person.GetDateOfBirth().Day}";
        }
    }
}