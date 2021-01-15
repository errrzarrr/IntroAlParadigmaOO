using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Vehicle
	{
		protected int Wheels;
        internal abstract void StartEngine();
		internal abstract void StopEngine();
	}
}

