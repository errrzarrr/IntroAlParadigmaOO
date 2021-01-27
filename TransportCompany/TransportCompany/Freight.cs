using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAppClassLIbrary
{
    public class Freight : Vehicle
    {
        private int loadCapacityTon;
        
        public void SetLoadCapacity(int loadCapacityTon)
        {
            if (loadCapacityTon > 0)
            {
                this.loadCapacityTon = loadCapacityTon; 
            } else Console.WriteLine("The load capacity of the freight must be greater than 0 metric tons");
        }
        
        public int GetLoadCapacity()
        {
            return this.loadCapacityTon;
        }
                
        public override void SetWheels(int wheels)
        {
            if (wheels == 8 || wheels == 10)
            {
                Console.WriteLine("Freights must have 8 or 10 wheels");
            }
            else this.wheels = wheels;
        }
        
        protected internal override void StartEngine()
        {
            Console.WriteLine("Starting freight on");
        }
        protected internal override void StopEngine()
        {
            Console.WriteLine("Turning freight off");
        }
    }
}
