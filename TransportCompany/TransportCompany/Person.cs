using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	class Person
	{
		string _Name;
		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;

			}
		}
		DateTime _DateOfBirth;
		public DateTime DateOfBirth
		{
			get
			{
				return _DateOfBirth;
			}
			set
			{
				_DateOfBirth = value;

			}
		}


		protected void Talk()
		{
			Console.WriteLine("I can talk :)");
		}

		
	}
}
