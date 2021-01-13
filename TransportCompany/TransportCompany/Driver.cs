using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Driver : IDriver
    {
        private String licenseId;
        private Vehicle vehicle;

        public void DriveVehicle()
        {
            Console.WriteLine("Driving...");
        }

        public void SetLicense(String licenseId)
        {
            this.licenseId = licenseId;
        }
        public String GetLicense()
        {
            return this.licenseId;
        }

        public void SetVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public Vehicle GetVehicle()
        {
            return this.vehicle;
        }

        private bool CanDriveThisVehicle()
        {
            return true;
        }
    }
}