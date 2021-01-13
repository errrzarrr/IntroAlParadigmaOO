using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Vehicle
	{
		protected int wheels;

		public abstract void StartEngine();
		public abstract void StopEngine();
	}
}