using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class Driver : Person, IDriver
	{
		private string licenseId;
		private Vehicle vehicle;

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
			return (licenseId != null);
		}
		public void DriveVehicle()
		{
			if (CanDriveThisVehicle()){
				Console.WriteLine("Driving vehicle as driver");
			}
		}
	}
}