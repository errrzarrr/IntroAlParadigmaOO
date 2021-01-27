using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    public class Car : Vehicle
    {
        protected internal override void StartEngine()
        {
            Console.WriteLine("Starting car on");
        }

        protected internal override void StopEngine()
        {
            Console.WriteLine("Turning car off"); ;
        }

        public override void SetWheels(int wheels)
        {
            if (wheels < 3)
            {
                Console.WriteLine("Car needs at least 3 wheels");
            } else this.wheels = wheels;
        }
        public override int GetWheels()
        {
            return this.wheels;
        }
    }
}
