using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    class Car : Vehicle
    {
        internal override void StartpEngine()
        {
            throw new NotImplementedException();
        }

        internal override void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void SetWheels(int wheels)
        {
            this.wheels = wheels;
        }
        public int GetWheels()
        {
            return this.wheels;
        }
    }
}
