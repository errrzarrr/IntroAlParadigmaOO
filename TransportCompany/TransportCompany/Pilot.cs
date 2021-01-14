using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class Pilot : Driver
	{
    protected int salary;
    public void SetSalary(int salary)
    {
        this.salary = salary;
    }
    public int GetSalary()
    {
        return this.salary;
    }

    public bool ValidLicense()
    {
        return (this.GetLicense().Substring(0, 4) == "Pro-");
    }

    public bool ValidAge()
    {
      return (this.GetDateOfBirth().AddYears(22) <= DateTime.UtcNow.Date);
    }

    public bool ValidSalary()
    {
      return this.salary >= 1000000;
    }
    public void CheckValidPilot()
        {
          try {
            if (ValidLicense() && ValidAge() && ValidSalary())
            {
              Console.WriteLine("Command authenticated. Standby for Titanfall.");
            }
            else if (!ValidLicense())
            {
              Console.WriteLine("Invalid license, you need a professional license to be a pilit.");
            }
            else if (!ValidAge())
            {
              Console.WriteLine("Too young to be a pilot, come back when you turn 22.");
            }
            else if (!ValidSalary())
            {
              Console.WriteLine("Valid license, but pilots are worth more than that.");
            }
            else
            {
              Console.WriteLine("I don't know why, but you can't be a pilot");
            }
          } catch {
              Console.WriteLine("ERROR: DESTRUCT SEQUENCE ENGAGED. EJECT NOW...");
          }
        }
  }
}