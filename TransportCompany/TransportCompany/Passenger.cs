using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {

        protected string origin;
        protected string destiny;

        public Passenger(string name, string origin, string destiny)
        {
            this.name = name;
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
