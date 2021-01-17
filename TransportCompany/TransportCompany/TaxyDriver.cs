using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClientApp
{
    class TaxyDriver : Driver
    {        
        private double _fee;

        public TaxyDriver() { }
        public TaxyDriver(Driver driver) : base(driver)
        {
            //
        }

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
        
        public void DrivePassenger(Passenger passenger)
        {
            Console.WriteLine($"Taxy driver {this._name} will drive {passenger.GetName()} from {passenger.GetOrigin()} to {passenger.GetDestination()}\n");
            Thread.Sleep(1000);

            this._vehicle.StartpEngine();
            Thread.Sleep(1000);
            this.DriveVehicle();
            Thread.Sleep(4000);

            Console.WriteLine($"Arrived at {passenger.GetDestination()}");
            Thread.Sleep(1000);
            Console.WriteLine($"Passenger {passenger.GetName()} is going to be ${this._fee} please");
            Thread.Sleep(4000);

            this._vehicle.StopEngine();
            Thread.Sleep(2000);
        }
    }
}
