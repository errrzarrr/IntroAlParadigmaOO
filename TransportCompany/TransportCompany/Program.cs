using System;

namespace ClientApp
{
	class Program
	{
		static void Main(string[] args) 
		{
			RunConsoleApp();
		}

		private static void RunConsoleApp()
		{
			Console.WriteLine("Hello User!");
			Console.WriteLine("Thank you for using our services. Press any key to exit...");
			Console.ReadKey();
		}
	}
}
