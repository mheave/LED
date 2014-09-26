using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Models;

namespace Entities
{
	public abstract class Rendering 
	{
		public abstract void RenderDisplay(int i);
		
		public NumericDisplay CreateNumericDisplayFromInteger(int integer)
		{
			var numericDisplay = new NumericDisplay();

			var integerAsArray = SplitIntIntoArray(integer);

			for(int b = 0; b < integerAsArray.Count(); b++)
			{
				IntegerMap map = IntegerMaps.GetMapForInteger(integerAsArray[b]);
				numericDisplay.Blocks.Add(new NumericDisplayBlock(b+1,map ));
			}
			return numericDisplay;
		}

		private static int[] SplitIntIntoArray(int intToSplit)
		{
			if (intToSplit == 0) 
				return new int[1] { 0 };
			
			var digits = new List<int>();

			for (; intToSplit != 0; intToSplit /= 10)
				digits.Add(intToSplit % 10);

			var arr = digits.ToArray();
			Array.Reverse(arr);
			return arr;
		}	
	}

	public class Line
	{
		public int LineNumber { get; set; }

		public string LineContents { get; set; }

	}

}
