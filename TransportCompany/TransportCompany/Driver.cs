using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

    class Driver: Person, IDriver
    {
        void IDriver.DriveVehicle()
        {
            Console.WriteLine($"{this} driving");
        }

        private Vehicle Vehicle;
        private string LicenseID;
        protected int Fee;
        

        public string GetLicenseID()
        {
            return LicenseID;
        }

        public void SetLicenseID(string licenseID)
        {
            LicenseID = licenseID;
        }

        public Vehicle GetVehicle()
        {
            return Vehicle; 
        } 
        public void SetVehicle(Vehicle vehicle )
        {
            Vehicle = vehicle ; 
        }

        public bool CanDriveThisVehicle(Vehicle vehicle)
        {
            return true;
        }

        internal override void Talk()
        {
            Console.WriteLine("Where do you want to go ?");
        }

    }


}