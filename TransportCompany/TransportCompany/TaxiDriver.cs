using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class TaxiDriver : Person, IDriver
    {

        protected Passenger passenger;
        protected int fee;
        protected int minTax = 100;
        protected int maxTax = 1000;

        public TaxiDriver(Passenger passenger)
        {
            this.passenger = passenger;
        }

        public override void Talk()
        {
            Console.WriteLine("Hi! i'm your taxi driver.");
        }

        public void DriveVehicle()
        {
            Console.WriteLine("Driving Car");
        }

        public void CarryThePassanger()
        {
            Console.WriteLine($"Carrying the passenger from {passenger.origin} to {passenger.destiny}");
        }

        public void ChargeToPassenger()
        {
            fee = RandomNumber(minTax, maxTax);

            passenger.Pay(fee);
        }

        public int RandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }

    }
}
