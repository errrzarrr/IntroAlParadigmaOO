using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class Driver : Person, IDriver
	{
		private string licenseId;
		private Car car;
		public void DriveVehicle()
		{
			car.StartEngine();
			Console.WriteLine("I'm a driver, let's drive");
		}
		public void SetCar(Car car)
		{
			this.car = car;
		}

	}
}