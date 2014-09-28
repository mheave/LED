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
		public NumericDisplay Display { get; set;}
		 
		
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

		protected List<RenderContents> CreateBlockLines()
		{
			var consoleRenderContents = new List<RenderContents>();
			foreach (var numericDisplayBlock in Display.Blocks)
			{
				var blockContent = new RenderContents { NumericDisplayBlock = numericDisplayBlock};
				blockContent.Lines.Add(LineOne(numericDisplayBlock));
				blockContent.Lines.Add(LineTwo(numericDisplayBlock));
				blockContent.Lines.Add(LineThree(numericDisplayBlock));
				blockContent.Lines.Add(LineFour(numericDisplayBlock));
				blockContent.Lines.Add(LineFive(numericDisplayBlock));
				consoleRenderContents.Add(blockContent);
			}
			return consoleRenderContents;
		}

		internal protected abstract Line LineOne(NumericDisplayBlock block);
		internal protected abstract Line LineTwo(NumericDisplayBlock block);
		internal protected abstract Line LineThree(NumericDisplayBlock block);
		internal protected abstract Line LineFour(NumericDisplayBlock block);
		internal protected abstract Line LineFive(NumericDisplayBlock block);
	}

	public class RenderContents
	{
		public NumericDisplayBlock NumericDisplayBlock { get; set; }
		public List<Line> Lines = new List<Line>();
	}

	public class Line
	{
		public int LineNumber { get; set; }

		public string LineContents { get; set; }

	}

}
