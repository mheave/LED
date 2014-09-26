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
		public NumericDisplay display { get; private set;}
		public int NumberOfBlocks { get { return display.Blocks.Count;} }
		public List<NumericDisplayBlock> Blocks { get { return display.Blocks;} }

		public override void RenderDisplay(int i)
		{
			display = CreateNumericDisplayFromInteger(i);
			CreateBlockLines();		
			RenderBlockLines();
		}

		public void RenderBlockLines()
		{
			var lineOne		= new StringBuilder();
			var lineTwo		= new StringBuilder();
			var lineThree	= new StringBuilder();
			var lineFour	= new StringBuilder();
			var lineFive	= new StringBuilder();

			foreach(NumericDisplayBlock block in Blocks)
			{
				lineOne.Append(block.Lines.First(l => l.LineNumber==1).LineContents);
				lineTwo.Append(block.Lines.First(l => l.LineNumber==2).LineContents);
				lineThree.Append(block.Lines.First(l => l.LineNumber==3).LineContents);
				lineFour.Append(block.Lines.First(l => l.LineNumber==4).LineContents);
				lineFive.Append(block.Lines.First(l => l.LineNumber==5).LineContents);
			}			
			
			Console.WriteLine(lineOne.ToString());
			Console.WriteLine(lineTwo.ToString());
			Console.WriteLine(lineThree.ToString());
			Console.WriteLine(lineFour.ToString());
			Console.WriteLine(lineFive.ToString());
		}

		private void CreateBlockLines()
		{
			foreach(var block in Blocks)
			{
				block.Lines.Add(LineOne(block));
				block.Lines.Add(LineTwo(block));
				block.Lines.Add(LineThree(block));
				block.Lines.Add(LineFour(block));
				block.Lines.Add(LineFive(block));
			}
		}

		#region Lines
		private Line LineOne(NumericDisplayBlock block)
		{
			string line = "   ";
			if(block.IntegerMap.BlockMap[SegmentPosition.Top].Equals(true))
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
			if(block.IntegerMap.BlockMap[SegmentPosition.UpperLeft].Equals(true))
			{
				lineString.Append("| ");
			}
			else
			{
				lineString.Append("  ");
			}
			if(block.IntegerMap.BlockMap[SegmentPosition.UpperRight].Equals(true))
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
			if(block.IntegerMap.BlockMap[SegmentPosition.Middle].Equals(true))
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
			if(block.IntegerMap.BlockMap[SegmentPosition.LowerLeft].Equals(true))
			{
				lineString.Append("| ");
			}
			else
			{
				lineString.Append("  ");
			}
			if(block.IntegerMap.BlockMap[SegmentPosition.LowerRight].Equals(true))
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
			if(block.IntegerMap.BlockMap[SegmentPosition.Bottom].Equals(true))
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
