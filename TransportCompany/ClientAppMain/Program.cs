using ClientApp;
using System;

namespace ClientAppMain
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
			
			//Test PayFee() Passed
			Passenger passFrancisco = new Passenger();
			passFrancisco.SetName("Francisco");
			TaxyDriver tdJorge = new TaxyDriver();
			tdJorge.SetName("Jorge");
			tdJorge.SetFee(100);
			passFrancisco.PayShuttleFee(tdJorge);
			/*
			//Test TaxyDriver.DrivePassenger() Passed
			Vehicle hyundaiSonata = new Car();
			tdJorge.SetVehicle(hyundaiSonata);
			passFrancisco.SetOrigin("Amalia Residentials");
			passFrancisco.SetDestination("Downtown Center");
			tdJorge.DrivePassenger(passFrancisco);
			

			//Test Pilot Class Passed
			Pilot pilotTom = new Pilot();
			pilotTom.SetName("Tom");
			pilotTom.SetDateOfBirth(1990, 8, 20);
			pilotTom.SetMaxDrivingSpeed(150);
			pilotTom.SetLicense("Pro-5656");
			// Console.WriteLine(pilotTom.ObtainDriverLicense());
			Console.WriteLine(pilotTom.GetLicense()); 
			

			//Test FreightDriver Class
			FreightDriver frJose = new FreightDriver();
			frJose.SetName("Jose");
			frJose.SetDateOfBirth(1989, 6, 25);
			frJose.SetFee(200);
			Console.WriteLine(frJose.ObtainDriverLicense() + frJose.GetFee());
			Vehicle bigWilly = new Truck();
			frJose.SetVehicle(bigWilly);
			frJose.DriveVehicle();

			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadLine();*/

		}
	}
}
