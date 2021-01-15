using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passenger : Person
    {
        protected string _origin;
        protected string _destination;
        private TaxyDriver _taxyDriver;

        public void SetOrigin(string origin)
        {
            if (origin != "")
            {
                this._origin = origin;
            } else Console.WriteLine("At least a word must be entered for the origin");
        }
        public string GetOrigin()
        {
            return this._origin;            
        }

        public void SetDestination(string destination)
        {
            if (destination != "")
            {
                this._destination = destination;
            }
            else Console.WriteLine("At least a word must be entered for the destination");
        }
        public string GetDestination()
        {
            return this._origin;
        }

        public void PayShuttleFee (TaxyDriver taxyDriver)
        {
            Console.WriteLine($"{this._name} paid {taxyDriver.GetFee()} to {taxyDriver.GetName()}");
        }
    }
}
