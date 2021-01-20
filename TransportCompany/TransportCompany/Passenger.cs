using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {

        protected string origin;
        protected string destiny;

        public void Pay(int fee)
        {
            Console.WriteLine($"Paying ${fee} to driver...");

        }

        public void SetOrigin(string origin)
        {
            this.origin = origin;
        }

        public string GetOrigin()
        {
            return this.origin;
        }

        public void SetDestiny(string destiny)
        {
            this.destiny = destiny;
        }

        public string GetDestiny()
        {
            return this.destiny;
        }

    }
}
