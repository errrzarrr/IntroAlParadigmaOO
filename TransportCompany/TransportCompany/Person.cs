using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Person
	{
    protected string name;
    protected DateTime dateOfBirth;
    public void Talk(String words)
    {
      Console.WriteLine(words);
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
    public String GetDateOfBirth ()
    {
      return this.dateOfBirth.ToString();
    }
  }
}