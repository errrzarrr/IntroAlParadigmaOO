using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAppClassLIbrary
{
    public class Truck : Vehicle
    {        
        public override void SetWheels(int wheels)
        {
            if (wheels < 6)
            {
                Console.WriteLine("Truck needs at least 6 wheels");
            }
            else this.wheels = wheels;
        }

        protected internal override void StartEngine()
        {
            Console.WriteLine("Starting truck on");
        }

        protected internal override void StopEngine()
        {
            Console.WriteLine("Turning truck off");
        }
    }
}
