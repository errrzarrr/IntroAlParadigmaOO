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

			//Person for driver
			Person frank = new Passenger();
			frank.SetName("Frank Montero");
			frank.SetDateOfBirth(1987, 9, 10);

			//Driver
			Driver frankDriver = new Driver(frank);
			frankDriver.ObtainDriverLicense();
			Console.WriteLine(frank.GetDateOfBirth().ToShortDateString());

			//Passenger
			Passenger jorge = new Passenger();
			jorge.SetName("Jorge Gonzalez");
			jorge.SetDateOfBirth(1985, 10, 10);
			jorge.SetOrigin("Torre Amelia Cristina");
			jorge.SetDestination("Downtown Center");

			//Testing start engine
			Vehicle civic = new Car();
			TaxyDriver frankTaxyDriver = new TaxyDriver(frankDriver);
			frankTaxyDriver.SetFee(100);
			frankTaxyDriver.SetVehicle(civic);
			frankTaxyDriver.DrivePassenger(jorge);

			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadLine();

		}	
	}
}
