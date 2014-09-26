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
			var consoleRender = new ConsoleRender();

			consoleRender.RenderDisplay(validInt);


			if (DEBUG) { 
			OutputToConsole(string.Format("Number of blocks: {0}",consoleRender.display.Blocks.Count()));

			foreach (var block in consoleRender.display.Blocks)
			{
				OutputToConsole(string.Format("Block number: {0}", block.BlockPosition));

				foreach (var segment in block.IntegerMap.BlockMap)
				{
					OutputToConsole(string.Format("segment {0} set to {1}", segment.Key, segment.Value));
				}

			}
			}

			

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
