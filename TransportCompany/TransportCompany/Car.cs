using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Car : Vehicle
    {
        internal override void StartEngine()
        {
                Console.WriteLine("*Start the engine* ");
        }

        internal override void StopEngine()
        {
           Console.WriteLine("*Stop the engine* ");
        }
    }
}
