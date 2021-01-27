using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClientAppClassLIbrary
{
    public class TaxyDriver : Driver
    {
        protected double fee;

        public void SetFee(double fee)
        {
            if (fee < 0)
            {
                Console.WriteLine("You must provide a positive amount");
            }
            else this.fee = fee;
        }
        public double GetFee()
        {
            return this.fee;
        }

        public void DrivePassenger(Passenger passenger)
        {
            Console.WriteLine($"Taxy driver {this.name} will drive {passenger.GetName()} from {passenger.GetOrigin()} to {passenger.GetDestination()}\n");
            Thread.Sleep(1000);

            this.DriveVehicle();
            Thread.Sleep(4000);

            Console.WriteLine($"Arrived at {passenger.GetDestination()}");
            Thread.Sleep(1000);
            Console.WriteLine($"Passenger {passenger.GetName()} is going to be ${this.fee} please");
            Thread.Sleep(4000);

            this.vehicle.StopEngine();
            Thread.Sleep(2000);
        }
    }
}
