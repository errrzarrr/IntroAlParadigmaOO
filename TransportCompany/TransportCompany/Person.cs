using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    abstract class Person
    {
        protected string _name = "Nobody";
        protected DateTime _dateOfBirth;

        public void SetName(String name)
        {
            if (int.TryParse(name, out _)) {
                Console.WriteLine("Name cannot be numbers");
            } else this._name = name;
        }
        public String GetName()
        {
            return this._name;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth <= DateTime.Today)
            {
                this._dateOfBirth = dateOfBirth;                
            } else Console.WriteLine("Date of birth cannot be a future date");
        }
        public DateTime GetDateOfBirth()
        {
            return this._dateOfBirth;
        }

        public void Talk()
        {
            Console.WriteLine($"{this._name} is talking");
        }


    }
}
