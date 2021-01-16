using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Truck : Vehicle
    {

        public Truck(int wheels)
        {
            if (wheels == 8 || wheels == 10)
                this.wheels = wheels;
            else 
                Console.WriteLine("A truck can only have 8 or 10 wheels.");
        }

        internal override void StartEngine()
        {
            Console.WriteLine("Truck engine is starting...");
        }

        internal override void StopEngine()
        {
            Console.WriteLine("Truck engine is stopping...");
        }
    }
}
