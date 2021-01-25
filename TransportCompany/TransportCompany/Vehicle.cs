using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract public class Vehicle
	{
		protected int wheels;

        protected internal abstract void StartEngine();
		protected internal abstract void StopEngine();

		public abstract void SetWheels(int wheels);
		public abstract int GetWheels();
	}
}

