using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp

{
    class Car : Vehicle
    {
      public Car()
      {
        this.wheels = 4;
      }
      public override void StartEngine()
      {
        Console.WriteLine($"Starting Engine for Car with {wheels} wheels.");
      }
      internal void SetWheels(int numOfWheels)
      {
        this.wheels = numOfWheels;
      }
      public override void StopEngine()
      {
        Console.WriteLine("Stopping Engine for Car");
      }

    }

}