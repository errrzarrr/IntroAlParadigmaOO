using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp

{
    class Car : Vehicle
    {
      public void SetWheels(int wheels)
      {
          this.wheels = wheels;
      }
      public int GetWheels()
      {
          return this.wheels;
      }
      public override void StartEngine()
      {
        Console.WriteLine($"Starting Engine for Car with {wheels} wheels.");
      }
      public override void StopEngine()
      {
        Console.WriteLine("Stopping Engine for Car");
      }

    }

}