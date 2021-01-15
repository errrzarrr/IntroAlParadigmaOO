using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
	abstract class Vehicle
	{
		protected int _wheels;
		protected string _model;
		protected string _brand;

		internal abstract void StartpEngine();
		internal abstract void StopEngine();

		public abstract void SetWheels(int wheels);
		public abstract int GetWheels();

		public abstract void SetModel(string model);
		public abstract string GetModel();

		public abstract void SetBrand(string brand);
		public abstract string GetBrand();
	}
}

