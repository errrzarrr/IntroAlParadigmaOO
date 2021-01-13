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
			Console.WriteLine("Hello User!");
			Passenger passenger1 = new Passenger("Los mameyes", "Av. La Gaviota");
			TaxiDriver taxiDriver = new TaxiDriver(passenger1);

			taxiDriver.CarryThePassanger();
			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadKey();
		}
	}
}
