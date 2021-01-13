using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class TaxiDriver : Driver
	{
        protected string pickupPoint;

        protected string passengerDestination;

        protected int passengerFee;

        protected int fee = 100;

        public void GetPickupPoint(String pickupPoint)
        {
            this.pickupPoint = pickupPoint;
            Console.WriteLine($"-Uber: Hello, I'm your uber. I'll pick you up at {this.pickupPoint}.");
        }
        public void GoToDestination(String passengerDestination)
        {
            this.passengerDestination = passengerDestination;
            Console.WriteLine($"-Uber: Alright, I see your destination is {this.passengerDestination}, let's go.");
        }
        public void TellFee ()
        {
            Console.WriteLine($"We have arrived, the fee is {this.fee}");
        }
        public void GetPassengerFee(int payment)
        {
            this.passengerFee = payment;
            Console.WriteLine($"Payment of {this.passengerFee} received, have a nice day.");
        }
    }
}
