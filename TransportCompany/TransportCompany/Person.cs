using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Person
	{
    protected string name;
    protected DateTime dateOfBirth;
    public void Talk()
    {
      Console.WriteLine($"*My name is {this.GetName()}");
    }
    public void SetName(String name)
    {
      this.name = name;
    }
    public String GetName ()
    {
      return this.name;
    }
    public void SetDateOfBirth(DateTime dateOfBirth)
    {
      this.dateOfBirth = dateOfBirth;
    }
    public DateTime GetDateOfBirth ()
    {
      return this.dateOfBirth;
    }
  }
}