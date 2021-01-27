using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAppClassLIbrary
{
	abstract public class Vehicle
	{
		protected int wheels;

        protected internal abstract void StartEngine();
		protected internal abstract void StopEngine();

		public abstract void SetWheels(int wheels);
		public int GetWheels()
        {
			return this.wheels;
        }
	}
}

