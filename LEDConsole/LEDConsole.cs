using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace LEDConsole
{
	public class LEDConsole
	{
		const bool DEBUG = false;
		readonly InputHandler _inputHandler = new InputHandler();

		public const string InputValueMessage = "Please enter an integer between 0 and 999:";
		public const string InvalidEntryMessage = "Sorry, {0} is not a valid input value.";

		public void MainAppThread()
		{
			while (true)
			{
				OutputToConsole(InputValueMessage);
				var enteredValue = Console.ReadLine();
				if (_inputHandler.IsInputValid(enteredValue))
				{
					ProcessValidInteger(int.Parse(enteredValue));
				}
				else
				{
					ProcessInvalidInteger(enteredValue);
				}
			}
		}

		public void ProcessValidInteger(int validInt)
		{
			var consoleRender = new ConsoleRender(validInt);

			consoleRender.RenderDisplay(validInt);	

		}

		public void ProcessInvalidInteger(string enteredValue)
		{
			OutputToConsole(string.Format(InvalidEntryMessage,enteredValue));
		}

		public static void OutputToConsole(string _output)
		{
			Console.WriteLine(_output);
		}
	}
}
