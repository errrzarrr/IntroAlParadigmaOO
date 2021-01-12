using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {

        public String origin;
        public String destiny;

        public Passenger(String origin, String destiny)
        {
            this.origin = origin;
            this.destiny = destiny;
        }

        public int Pay(Driver driver)
        {
            Console.WriteLine("Paying...");

            return 10;
        }

        public String GetOrigin()
        {
            return this.origin;
        }

        public String GetDestiny()
        {
            return this.destiny;
        }

    }
}
