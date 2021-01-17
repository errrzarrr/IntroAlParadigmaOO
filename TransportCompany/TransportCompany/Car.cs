using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Car : Vehicle
    {
        internal override void StartpEngine()
        {
            Console.WriteLine("Starting car");
        }

        internal override void StopEngine()
        {
            Console.WriteLine("Turning car off"); ;
        }

        public override void SetWheels(int wheels)
        {
            
            this._wheels = wheels;
        }
        public override int GetWheels()
        {
            return this._wheels;
        }

        public override void SetModel(string model)
        {
            if (model == "")
            {
                Console.WriteLine("Please enter a valid vehicle model");
            }
            else this._model = model;      
        }

        public override string GetModel()
        {
            return this._model;
        }

        public override void SetBrand(string brand)
        {
            if (brand == "")
            {
                Console.WriteLine("Please enter a valid vehicle brand");
            }
            else this._brand = brand;
        }

        public override string GetBrand()
        {
            return this._brand;
        }
    }
}
