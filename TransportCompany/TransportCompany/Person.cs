using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    abstract class Person
    {
        protected string name;
        protected DateTime dateOfBirth;

        public virtual void Talk()
        {
            Console.WriteLine("I'm talking");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public DateTime GetDateOfBirth()
        {
            return this.dateOfBirth;
        }
    }
}
