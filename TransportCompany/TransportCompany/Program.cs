using System;

namespace ClientApp
{
	class Program
	{
		static void Main(string[] args)
		{
			RunConsoleApp();
		}

		private static void RunConsoleApp()
		{
			Console.WriteLine("Hello!, welcome to our Transport Company!");
			Passenger tourist = new Passenger();
			TaxiDriver uber = new TaxiDriver();
			tourist.SetOrigin("Downtown Center");
			tourist.Talk("*Tourist: Hi, I'm a turist, I need an uber.");
			uber.GetPickupPoint(tourist.GetOrigin());
			tourist.Talk("*Tourist: Wow, that was fast, I'll get in the car.");
			tourist.SetDestination("Galería 360");
			uber.GoToDestination(tourist.GetOrigin());
			uber.TellFee();
			uber.GetPassengerFee(tourist.PayFee());

			//Console.WriteLine("Ready to take you to your destination at {passengerDestination}");B
			Car myCar = new Car();
			// myCar.SetWheels(3);
			// Driver driver = new Driver();
			// driver.SetName("Carlos");
			// driver.Talk();
			// driver.SetCar(myCar);
			// driver.DriveVehicle();
			// Your code here...
			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadLine();
		}
	}
}
