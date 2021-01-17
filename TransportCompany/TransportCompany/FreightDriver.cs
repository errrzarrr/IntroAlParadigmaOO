using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class FreightDriver : Driver
	{
    protected int fee;
    public void SetFee(int fee)
    {
        this.fee = fee;
    }
    public int GetFee()
    {
        return this.fee;
    }

    public bool ValidLicense()
    {
        return (this.GetLicense().ToLower().Substring(0, 6) == "heavy-");
    }
    public bool ValidAge()
    {
      return (this.GetDateOfBirth().AddYears(20) <= DateTime.UtcNow.Date);
    }
    public bool ValidFee()
    {
      return this.fee > 0;
    }
    public void CheckValidFreight()
        {
          try {
            if (ValidLicense() && ValidAge() && ValidFee())
            {
              Console.WriteLine("Valid license and age, Enjoy your trip.");
            }
            else if (!ValidLicense())
            {
              Console.WriteLine("Invalid license, you need a heavy license to drive a Freight.");
            }
            else if (!ValidAge())
            {
              Console.WriteLine("Too young to driver a Freight, come back when you turn 20.");
            }
            else if (!ValidFee())
            {
              Console.WriteLine("Valid license, but we need a higher payment to move a Freight.");
            }
            else
            {
              Console.WriteLine("I don't know why, but you can't drive Freight...");
            }
          } catch {
              Console.WriteLine("Error: something went very wrong...");
          }
        }
  }
}