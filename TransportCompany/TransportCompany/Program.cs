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

			Passenger frank = new Passenger();
			frank.SetName("Frank Montero");
			frank.SetDateOfBirth(1987, 9, 10);

			Driver frankDriver = new Driver();
			frankDriver.ObtainDriverLicense(frank);
			Console.WriteLine(frank.GetDateOfBirth().ToShortDateString());

			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadLine();
		}
	}
}
