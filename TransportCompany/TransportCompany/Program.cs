using System;
using System.Threading;

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

			Car car1 = new Car(4);
			Passenger passenger1 = new Passenger();
			TaxiDriver taxiDriver = new TaxiDriver(passenger1, car1);
			Pilot pilot = new Pilot();

			passenger1.SetName(GetNameOfUser());
			Loading();
			Console.Clear();

			passenger1.SetOrigin(GetUserLocation());
			Loading();
			Console.Clear();

			passenger1.SetDestiny(GetUserDestiny());
			Loading();
			Console.Clear();


			taxiDriver.SetVehicle(car1);
			taxiDriver.SetLicense("1234");
			taxiDriver.DriveVehicle();
			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadKey();
		}

		private static void Loading()
        {
			int time = 300;
			int timesOfExecution = 3;
			Console.Write("Loading");
			for (int i = 0; i < timesOfExecution; i++)
			{
				Thread.Sleep(time);
				Console.Write(".");
			}
			Console.WriteLine("");
		}

		public static string GetNameOfUser()
        {
			Console.WriteLine("What is your name?");
			return Console.ReadLine();

		}

		public static string GetUserLocation()
		{
			Console.WriteLine("Where are you?");
			return Console.ReadLine();

		}

		public static string GetUserDestiny()
		{
			Console.WriteLine("What is your destiny?");
			return Console.ReadLine();

		}

	}
}
