using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    abstract public class Person
    {
        protected string name = "Nobody";
        protected DateTime dateOfBirth;
        protected int age;

        public void SetName(string name)
        {
            if (int.TryParse(name, out _) || name == "")
            {
                Console.WriteLine("Please enter a valid name");
            } else this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetDateOfBirth(int year, int month, int day)
        {
            DateTime dateOfBirth = new DateTime(year, month, day);

            if (dateOfBirth <= DateTime.Today)
            {
                this.dateOfBirth = dateOfBirth;
                SetAge();
            } else Console.WriteLine("Date of birth cannot be a future date");
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {            
            if (dateOfBirth <= DateTime.Today)
            {
                this.dateOfBirth = dateOfBirth;
                SetAge();
            }
            else Console.WriteLine("Date of birth cannot be a future date");
        }
        public DateTime GetDateOfBirth()
        {
            return this.dateOfBirth;
        }

        private void SetAge()
        {
            if (this.dateOfBirth != default)
            {
                this.age = DateTime.Today.Year - this.GetDateOfBirth().Year;
            }
        }

        public int GetAge()
        {
            return this.age;
        }

        public void Talk()
        {
            Console.WriteLine($"{this.name} is talking");
        }
    }
}
