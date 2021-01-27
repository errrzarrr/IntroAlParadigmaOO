using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAppClassLIbrary
{
    public class Passenger : Person
    {
        protected string origin;
        protected string destination;

        public void SetOrigin(string origin)
        {
            if (origin != "")
            {
                this.origin = origin;
            } else Console.WriteLine("Please enter a valid pick up location");
        }
        public string GetOrigin()
        {
            return this.origin;            
        }

        public void SetDestination(string destination)
        {
            if (destination != "")
            {
                this.destination = destination;
            }
            else Console.WriteLine("Please enter a valid destination");
        }
        public string GetDestination()
        {
            return this.destination;
        }

        public void PayShuttleFee (TaxyDriver taxyDriver)
        {
            Console.WriteLine($"{this.name} pays {taxyDriver.GetFee()} to {taxyDriver.GetName()}");
        }
    }
}
