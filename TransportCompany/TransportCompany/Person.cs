using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	 abstract class Person
	{
		private string Name;
		
		
			public string GetName()
			{
				return Name;
			}
			public void SetName(string name)
			{
			Name = name;

			}
		
		private DateTime _DateOfBirth;
		
			public DateTime GetDateOfBrith()
			{
				return _DateOfBirth;
			}
		public void SetDateOfBirth(DateTime dateofbirth)
			{
				_DateOfBirth = dateofbirth;

			}



		internal abstract void Talk();

		
	}
}
