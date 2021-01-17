using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Driver : Person, IDriver
    {
        protected string _licenseId;
        protected Vehicle _vehicle;

        public Driver() { }
        
        public Driver(Person person)
        {
            this.SetName(person.GetName());
            this.SetDateOfBirth(person.GetDateOfBirth());
        }
       
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
            if (vehicle is Car)
                this._vehicle = vehicle;
        }
        public Vehicle GetVehicle()
        {
            return this._vehicle;
        }
                
        private bool CanDriveThisVehicle(Vehicle vehicle)
        {
            bool isAbleTo = false;
            
            if (vehicle is Car)
            {
                isAbleTo = true;
            }
            
            return isAbleTo;
        }

        public virtual void ObtainDriverLicense()
        {
            int age = DateTime.Today.Year - this.GetDateOfBirth().Year;

            if (age < 18)
            {
                Console.WriteLine("You are not old enough to get a driver's license");
            }
            else this._licenseId = $"{this.GetName()}{this.GetDateOfBirth().Year}{this.GetDateOfBirth().Month}{this.GetDateOfBirth().Day}";
        }
    }
}