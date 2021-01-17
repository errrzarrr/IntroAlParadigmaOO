using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Freight : Vehicle
    {
        private int _loadCapacityTonne;
        
        public void SetLoadCapacity(int loadCapacityTonne)
        {
            if (loadCapacityTonne > 0)
            {
                this._loadCapacityTonne = loadCapacityTonne; 
            } else Console.WriteLine("The load capacity of the freight must be greater than 0 metric tons");
        }

        public override string GetBrand()
        {
            throw new NotImplementedException();
        }

        public override string GetModel()
        {
            throw new NotImplementedException();
        }

        public override int GetWheels()
        {
            throw new NotImplementedException();
        }

        public override void SetBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public override void SetModel(string model)
        {
            throw new NotImplementedException();
        }

        public override void SetWheels(int wheels)
        {
            if (wheels < 8 && wheels > 10)
            {
                Console.WriteLine("Freights must have from 8 to 10 wheels");
            }
            else this._wheels = wheels;
        }

        internal override void StartpEngine()
        {
            throw new NotImplementedException();
        }

        internal override void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
