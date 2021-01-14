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
            Console.WriteLine($"-Uber: I'm your uber. I'll pick you up at {this.pickupPoint}.");
            Console.WriteLine("-Uber: Now, where are we going?");
        }
        public void GoToDestination(String passengerDestination)
        {
            this.passengerDestination = passengerDestination;
            Console.WriteLine($"-Uber: Alright, I see your destination is {this.passengerDestination}, let's go.");
        }
        public void TellFee ()
        {
            Console.WriteLine($"-Uber: We have arrived, the fee is {this.fee}.");
        }
        public void GetPassengerFee(String payment)
        {
            try {
                this.passengerFee = int.Parse(payment);
            if (passengerFee < fee){
                Console.WriteLine($"-Uber: Payment of ${this.passengerFee} is incomplete, I'll report you to the police");
            } else if (passengerFee > fee) {
                Console.WriteLine($"-Uber: Payment of ${this.passengerFee} received, thank you for the tip.");
            } else if (passengerFee == 100) {
                Console.WriteLine($"-Uber: Payment of ${this.passengerFee} received, have a nice day.");
            }
            } catch {
                Console.WriteLine($"-Uber: Error processing payment.");
            }
        }
    }
}
