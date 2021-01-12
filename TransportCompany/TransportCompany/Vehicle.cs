using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Vehicle
	{
		protected int wheels;

		internal abstract void StartpEngine();
		internal abstract void StopEngine();
	}
}

