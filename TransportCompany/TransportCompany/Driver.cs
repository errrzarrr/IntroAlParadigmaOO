using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

	class Driver : IDriver
	{
		 void IDriver.DriveVehicle()
        {
			Console.WriteLine("i am driving");
        }


		private string licenseID;
        public string LicenseID { get => licenseID; set => licenseID = value; }

        private Vehicle Vehicle;
        internal Vehicle Vehicle1 { get => Vehicle; set => Vehicle = value; }

        public bool CanDriveThisVehicle( Vehicle vehicle)
        {
            return  true ;
        }
    }
}