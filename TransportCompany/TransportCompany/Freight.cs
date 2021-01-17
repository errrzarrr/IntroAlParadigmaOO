using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp

{
    class Freight : Vehicle
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
        if (this.wheels == 8 || this.wheels == 10) {
          Console.WriteLine($"Starting Engine for Freight with {wheels} wheels.");
        } else {
          Console.WriteLine($"This Freight needs more wheels.");
        }
      }
      public override void StopEngine()
      {
        Console.WriteLine("Stopping Engine for Freight");
      }

    }

}