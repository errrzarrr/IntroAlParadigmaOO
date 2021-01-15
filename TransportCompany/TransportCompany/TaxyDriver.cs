using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class TaxyDriver : Driver
    {
        private double _fee;

        public void SetFee(double fee)
        {
            if (fee < 0)
            {
                Console.WriteLine("You must provide a positive number");
            } else this._fee = fee;
        }
        public double GetFee()
        {
            return this._fee;
        }

        //TODO Control how fast the instructions run
        public void DrivePassenger(Passenger passenger)
        {
            Console.WriteLine($"Taxy driver {this._name} will drive {passenger.GetName()} from {passenger.GetOrigin()} to {passenger.GetDestination()}");
            this.DriveVehicle();
            Console.WriteLine($"Arrived at {passenger.GetDestination()}");
            Console.WriteLine($"Passenger {passenger.GetName()} is going to be ${this._fee} please");
        }
    }
}
