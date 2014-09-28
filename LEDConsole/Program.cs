using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace LEDConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" ----- Welcome to LED. The console version! -----\n\n");
			
			var console = new LEDConsole();
			console.MainAppThread();

			Console.ReadLine();
		}

	}
}
