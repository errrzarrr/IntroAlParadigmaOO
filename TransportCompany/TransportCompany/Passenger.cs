using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {
        public String origin;
        public String destiny;

        public int Pay(Driver driver)
        {
            Console.WriteLine("Paying...");

            return 10;
        }
    }
}
