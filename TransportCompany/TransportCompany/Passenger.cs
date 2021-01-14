using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp

{
    class Passenger : Person
    {
        protected string origin;

        protected string destination;

        protected string fee;

        public void SetOrigin(String origin)
        {
            this.origin = origin;
        }
        public String GetOrigin()
        {
            return this.origin;
        }
        public void SetDestination(String destination)
        {
            this.destination = destination;
        }
        public String GetDestination()
        {
            return this.destination;
        }
        public void SetFee(String fee)
        {
            this.fee = fee;
        }
        public String PayFee()
        {
            return this.fee;
        }
    }
}