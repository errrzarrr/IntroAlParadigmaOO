using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Car : Vehicle
    {

        public Car(int wheels)
        {
            this.wheels = wheels;
        }

        internal override void StartEngine()
        {
            Console.WriteLine("TaxiDriver is starting Engine...");
        }

        internal override void StopEngine()
        {
            Console.WriteLine("TaxiDriver is stopping Engine...");
        }

        public int GetWheels()
        {
            return wheels;
        }
    }
}
