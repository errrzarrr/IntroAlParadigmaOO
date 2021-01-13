using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClientApp
{
    class TaxiDriver : Driver
    {

        protected Passenger passenger;
        protected int fee;
        protected int minTax = 100;
        protected int maxTax = 1000;

        public TaxiDriver(Passenger passenger, Car car)
        {
            this.passenger = passenger;
            SetVehicle(car);
        }

        public override void Talk()
        {
            Console.WriteLine("Hi! i'm your taxi driver.");
        }

        public override void DriveVehicle()
        {

            int timeInMS = 2000;
            if (CanDriveThisVechicle())
            {
                Talk();

                Thread.Sleep(timeInMS);
                GetVehicle().StartEngine();

                Thread.Sleep(timeInMS);
                Console.WriteLine("TaxiDriver is going to your location, be ready for go out... Press any key to indicate that you are ready.");
                Console.ReadKey();
                Thread.Sleep(timeInMS);

                Console.Clear();
                Thread.Sleep(timeInMS - 500);
                PickUpPassenger();

                Thread.Sleep(timeInMS);
                Console.Clear();
                CarryThePassanger();

                Thread.Sleep(timeInMS + 1000);
                Console.Clear();
                ArrivingToDestiny();

                Thread.Sleep(timeInMS);
                GetVehicle().StopEngine();

                Thread.Sleep(timeInMS - 1000);
                ChargeToPassenger();
            }
            else
                Console.WriteLine("Driver doesn't have license, so he can't drive!");

        }

        public void PickUpPassenger()
        {
            Console.WriteLine($"Going to pick up {passenger.GetName()} to {passenger.GetOrigin()}");
        }

        private void CarryThePassanger()
        {
            Console.WriteLine($"Carrying {passenger.GetName()} from {passenger.GetOrigin()} to {passenger.GetDestiny()}...");
        }

        public void ArrivingToDestiny()
        {
            Console.WriteLine($"Arriving to {passenger.GetDestiny()}...");
        }

        private bool CanDriveThisVechicle()
        {
            if (string.IsNullOrEmpty(GetLicense())) return false;
            else return true;
        }

        public void ChargeToPassenger()
        {
            fee = RandomNumber(minTax, maxTax);

            Console.WriteLine($"Your trip is over, you must pay ${fee} pesos.");
            passenger.Pay(fee);
        }

        public int RandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }

    }
}
