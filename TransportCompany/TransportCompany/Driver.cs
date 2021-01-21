using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class Driver : Person, IDriver
	{
		private string licenseId;
		private Vehicle vehicle;

		public virtual void SetLicense(string licenseId)
        {
			this.licenseId = licenseId;
        }

		public string GetLicense()
        {
			return licenseId;
        }

		public void SetVehicle(Vehicle vehicle)
        {
			this.vehicle = vehicle;
        }

		public Vehicle GetVehicle()
        {
			return vehicle;
        }

		bool CanDriveThisVechicle()
        {
			if (string.IsNullOrEmpty(licenseId)) return false;
			else return true;
		}

		public virtual void DriveVehicle() {

			if (CanDriveThisVechicle())
				Console.WriteLine("Driving Vehicle");
			else
				Console.WriteLine($" {this} doesn't have license, so he can't drive!");

		}

		protected bool ValidAge(int age)
        {
			return DateTime.Now.Year - GetDateOfBirth().Year >= age ? true : false;
        }

	}
}