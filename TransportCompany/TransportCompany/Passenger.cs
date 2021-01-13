using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {

        public string origin;
        public string destiny;

        public Passenger(string origin, string destiny)
        {
            this.origin = origin;
            this.destiny = destiny;
        }

        public void Pay(int fee)
        {
            Console.WriteLine($"Paying ${fee} to driver...");

        }

        public string GetOrigin()
        {
            return this.origin;
        }

        public string GetDestiny()
        {
            return this.destiny;
        }

    }
}
