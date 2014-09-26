using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InputHandler
    {
		private const int MaxIntSize = 999;
		private const int MinIntSize = 0;

		public bool IsInputValid(string input)
		{
			int enteredInt;
			if (!int.TryParse(input, out enteredInt))
				return false;

			return enteredInt >= MinIntSize && enteredInt <= MaxIntSize;
		}


		
    }
}
