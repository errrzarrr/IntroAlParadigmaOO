using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class TaxiDriver : Driver
    {

        public Passenger passenger;

        public TaxiDriver(Passenger passenger)
        {
            this.passenger = passenger;
        }

        public void CarryThePassanger()
        {
            Console.WriteLine($"Carrying the passenger from {passenger.origin} to {passenger.destiny}");
        }

    }
}
