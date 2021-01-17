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
			string scenario;
			Console.Clear();
			Console.WriteLine("-What scenario would you like to run?");
			Console.WriteLine("1: Passenger | 2: Pilot | 3: FreightDriver");
			scenario = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("-Welcome to our Transport Company!");

			if (scenario == "1")
			{
				Passenger tourist = new Passenger();
				TaxiDriver uber = new TaxiDriver();
				Car taxiCar = new Car();

				uber.SetLicense("Taxi-E1G47");
				uber.SetVehicle(taxiCar);
				// taxiCar.StartEngine(); // this must not be allowed
				Console.WriteLine("-Passenger, please enter your name:");
				tourist.SetName(Console.ReadLine());
				tourist.Talk();
				Console.WriteLine($"-Hello {tourist.GetName()}, where should we pick you up?");
				tourist.SetOrigin(Console.ReadLine());
				uber.GetPickupPoint(tourist.GetOrigin());
				tourist.SetDestination(Console.ReadLine());
				uber.GoToDestination(tourist.GetDestination());
				uber.TellFee();
				Console.WriteLine("-Please enter your payment amount:");
				tourist.SetFee(Console.ReadLine());
				uber.GetPassengerFee(tourist.PayFee());
				Console.WriteLine("--Thank you for using our services. Press any key to exit...");
			}
			else if (scenario == "2")
			{
				Pilot pilot = new Pilot();
				Car titan = new Car();

				pilot.SetVehicle(titan);
				Console.WriteLine("-Pilot, please enter your name:");
				pilot.SetName(Console.ReadLine());
				pilot.Talk();
				Console.WriteLine($"-Hello {pilot.GetName()}, license number please?");
				pilot.SetLicense(Console.ReadLine());
				Console.WriteLine($"-Thank you, please enter your DOB as YYYY-MM-DD");
				pilot.SetDateOfBirth(DateTime.Parse(Console.ReadLine()));
				Console.WriteLine($"-Thank you, please enter your salary");
				pilot.SetSalary(int.Parse(Console.ReadLine()));
				pilot.CheckValidPilot();
			}
			else if (scenario == "3")
			{
				FreightDriver freightDriver = new FreightDriver();
				Freight oneFreight = new Freight();

				freightDriver.SetVehicle(oneFreight);
				oneFreight.SetWheels(10);
				Console.WriteLine("-Driver, please enter your name:");
				freightDriver.SetName(Console.ReadLine());
				freightDriver.Talk();
				Console.WriteLine($"-Hello {freightDriver.GetName()}, license number please?");
				freightDriver.SetLicense(Console.ReadLine());
				Console.WriteLine($"-Thank you, please enter your DOB as YYYY-MM-DD");
				freightDriver.SetDateOfBirth(DateTime.Parse(Console.ReadLine()));
				Console.WriteLine($"-Thank you, please enter your free");
				freightDriver.SetFee(int.Parse(Console.ReadLine()));
				freightDriver.CheckValidFreight();
			}
			else
			{
				Console.WriteLine("-Didn't receive a valid input. Press any key to exit...");
			}
			Console.ReadKey();
		}
	}
}