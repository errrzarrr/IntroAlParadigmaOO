using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    abstract class Person
    {
        protected string _name = "Nobody";
        protected DateTime _dateOfBirth;

        public void SetName(string name)
        {
            if (int.TryParse(name, out _) || name == "")
            {
                Console.WriteLine("Please enter a valid name");
            } else this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }

        public void SetDateOfBirth(int year, int month, int day)
        {
            DateTime dateOfBirth = new DateTime(year, month, day);

            if (dateOfBirth <= DateTime.Today)
            {
                this._dateOfBirth = dateOfBirth;                
            } else Console.WriteLine("Date of birth cannot be a future date");
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {            
            if (dateOfBirth <= DateTime.Today)
            {
                this._dateOfBirth = dateOfBirth;
            }
            else Console.WriteLine("Date of birth cannot be a future date");
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
