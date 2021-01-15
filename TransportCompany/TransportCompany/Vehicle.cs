using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Vehicle
	{
		private int Wheels;
        internal abstract void StartpEngine();
		internal abstract void StopEngine();
	}
}

