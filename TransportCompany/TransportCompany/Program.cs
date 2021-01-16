using System;
using System.Threading;

namespace ClientApp
{
	class Program
	{

		static readonly Car car1 = new Car();
		static readonly Truck truck = new Truck(4);
		static readonly Passenger passenger1 = new Passenger();
		static readonly TaxiDriver taxiDriver = new TaxiDriver(DateTime.Parse("2004/6/1"), passenger1, car1, "1234");
		static readonly Pilot pilot = new Pilot(DateTime.Parse("2008/6/1"), car1, "1234");
		static readonly FreightDriver freight = new FreightDriver(DateTime.Parse("2004/6/1"), truck, "1234");

		static void Main(string[] args)
		{
			RunConsoleApp();
		}

		private static void RunConsoleApp()
		{

			Console.WriteLine("\nHello User!\n");

			passenger1.SetName(GetNameOfUser());
			Loading();
			Console.Clear();

			MainMenu(passenger1);

            Console.WriteLine("Thank you for using our services. Press any key to exit...");
            Console.ReadKey();
        }

		private static void MainMenu(Passenger passenger)
        {
			int input = 0;
			string[] array = {"1- Call a Taxi Driver.", "2- Call a Pilot Driver.", "3- Call a Freight Driver.", "4- Exit"};

			void RenderMenu(int input, string[] array)
            {
				Console.WriteLine("===================== MENU ======================\n");

				foreach (string option in array)
				{
					Console.WriteLine(option);
				}

                input = int.Parse(Console.ReadLine());

				Thread.Sleep(400);
				Console.Clear();

				switch (input)
				{

					case 1:

						if (string.IsNullOrEmpty(taxiDriver.GetLicense()))
							break;
						else
						{
							passenger.SetOrigin(GetUserLocation());
							Loading();
							Console.Clear();

							passenger.SetDestiny(GetUserDestiny());
							Loading();
							Console.Clear();

							taxiDriver.DriveVehicle();

							break;
						}

					case 2:

						Console.WriteLine(input);

						break;

					case 3:

						Console.WriteLine(input);

						break;

					case 4:

						Console.WriteLine(input);

						break;

					default:

						Console.WriteLine("You inserted an invalid option... Try again.");

						RenderMenu(input, array);

						break;

				}
			}

            RenderMenu(input, array);
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

		private static string GetNameOfUser()
        {
			Console.WriteLine("What is your name?");
			return Console.ReadLine();

		}

		private static string GetUserLocation()
		{
			Console.WriteLine("Where are you?");
			return Console.ReadLine();

		}

		private static string GetUserDestiny()
		{
			Console.WriteLine("What is your destiny?");
			return Console.ReadLine();

		}

	}
}
