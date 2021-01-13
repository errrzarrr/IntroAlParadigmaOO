using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{

    class Pilot : Person, IDriver
    {

        protected string license;

        public void DriveVehicle()
        {
            Console.WriteLine("Hi! i'm your pilot drive");
        }

    }
}
