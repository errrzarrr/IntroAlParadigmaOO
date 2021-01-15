using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Passanger : Person
    {
        private string Destiny;
        private string Origin;


        public void SetDestiny(string destiny)
        {
            Destiny = destiny;
        }
        public string GetDestiny()
        {
           return Destiny;
        }

        public void SetOrigin(string origin)
        {
            Origin= origin;
        }
        public string GetOrigin()
        {
            return Origin;
        }
        internal override void Talk()
        {
            Console.WriteLine($"I wanna go to {this.Destiny}");
        }
        internal void Pay(Driver Driver)
        {
            
        }
    }
}
