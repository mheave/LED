using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.SqlServer.Server;
using Models;

namespace Services
{
	public class ConsoleRender : Rendering 
	{
		public NumericDisplay Display { get; private set;}
		private readonly List<ConsoleRenderContents> _consoleRenderContents = new List<ConsoleRenderContents>();

		public ConsoleRender(int i)
		{
			Display = CreateNumericDisplayFromInteger(i);
			CreateBlockLines();	
		}

		public override void RenderDisplay(int i)
		{
			RenderBlockLines();
		}

		public void RenderBlockLines()
		{
			var lineOne		= new StringBuilder();
			var lineTwo		= new StringBuilder();
			var lineThree	= new StringBuilder();
			var lineFour	= new StringBuilder();
			var lineFive	= new StringBuilder();

			foreach(var consoleContent in _consoleRenderContents)
			{
				lineOne.Append(consoleContent.Lines.First(l => l.LineNumber==1).LineContents);
				lineTwo.Append(consoleContent.Lines.First(l => l.LineNumber==2).LineContents);
				lineThree.Append(consoleContent.Lines.First(l => l.LineNumber==3).LineContents);
				lineFour.Append(consoleContent.Lines.First(l => l.LineNumber==4).LineContents);
				lineFive.Append(consoleContent.Lines.First(l => l.LineNumber==5).LineContents);
			}			
			
			Console.WriteLine(lineOne.ToString());
			Console.WriteLine(lineTwo.ToString());
			Console.WriteLine(lineThree.ToString());
			Console.WriteLine(lineFour.ToString());
			Console.WriteLine(lineFive.ToString());
		}

		private void CreateBlockLines()
		{
			foreach (var numericDisplayBlock in Display.Blocks)
			{
				var blockContent = new ConsoleRenderContents { NumericDisplayBlock = numericDisplayBlock};
				blockContent.Lines.Add(LineOne(numericDisplayBlock));
				blockContent.Lines.Add(LineOne(numericDisplayBlock));
				blockContent.Lines.Add(LineTwo(numericDisplayBlock));
				blockContent.Lines.Add(LineThree(numericDisplayBlock));
				blockContent.Lines.Add(LineFour(numericDisplayBlock));
				blockContent.Lines.Add(LineFive(numericDisplayBlock));
			}
		}

		#region Lines
		private Line LineOne(NumericDisplayBlock block)
		{
			string line = "   ";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Top).IsOn.Equals(true))
			{
				line = " _ ";
			}
			return new Line
			{
				LineNumber = 1,
				LineContents = line
			};
		}

		private Line LineTwo(NumericDisplayBlock block)
		{
			var lineString = new StringBuilder();
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.UpperLeft).IsOn.Equals(true))
			{
				lineString.Append("| ");
			}
			else
			{
				lineString.Append("  ");
			}
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.UpperRight).IsOn.Equals(true))
			{
				lineString.Append("|");
			}
			else
			{
				lineString.Append(" ");
			}
			return new Line
			{
				LineNumber = 2,
				LineContents =  lineString.ToString()
			};
		}

		private Line LineThree(NumericDisplayBlock block)
		{
			var line = "   ";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Middle).IsOn.Equals(true))
			{
				line = " - ";
			}
			return new Line
			{
				LineNumber = 3,
				LineContents = line
			};
		}

		private Line LineFour(NumericDisplayBlock block)
		{
			var lineString = new StringBuilder();
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.LowerLeft).IsOn.Equals(true))
			{
				lineString.Append("| ");
			}
			else
			{
				lineString.Append("  ");
			}
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.LowerRight).IsOn.Equals(true))
			{
				lineString.Append("|");
			}
			else
			{
				lineString.Append(" ");
			}
			return new Line
			{
				LineNumber = 4,
				LineContents =  lineString.ToString()
			};
		}

		private Line LineFive(NumericDisplayBlock block)
		{
			var line = "   ";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Bottom).IsOn.Equals(true))
			{
				line = " - ";
			}
			return new Line
			{
				LineNumber = 5,
				LineContents = line
			};
		}
		#endregion 
	}
}
