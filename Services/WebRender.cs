using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using LEDWeb.Models;
using Models;

namespace Services {
	public class WebRender : Rendering 
	{
		private readonly List<RenderContents> _webRenderContents = new List<RenderContents>();

		public WebRender(int i)
		{
			Display = CreateNumericDisplayFromInteger(i);
			_webRenderContents = CreateBlockLines();
		}

		public override void RenderDisplay(int i)
		{
			// set html properties
		}



		#region Lines
		protected override Line LineOne(NumericDisplayBlock block)
		{
			string line = "&nbsp;&nbsp;&nbsp;&nbsp;";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Top).IsOn.Equals(true))
			{
				line = "&nbsp;--&nbsp;";
			}
			return new Line
			{
				LineNumber = 1,
				LineContents = line
			};
		}

		protected override Line LineTwo(NumericDisplayBlock block)
		{
			var lineString = new StringBuilder();
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.UpperLeft).IsOn.Equals(true))
			{
				lineString.Append("|&nbsp;&nbsp;");
			}
			else
			{
				lineString.Append("&nbsp;&nbsp;&nbsp;");
			}
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.UpperRight).IsOn.Equals(true))
			{
				lineString.Append("&nbsp;|");
			}
			else
			{
				lineString.Append("&nbsp;");
			}
			return new Line
			{
				LineNumber = 2,
				LineContents =  lineString.ToString()
			};
		}

		protected override Line LineThree(NumericDisplayBlock block)
		{
			var line = "&nbsp;&nbsp;&nbsp;&nbsp;";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Middle).IsOn.Equals(true))
			{
				line = "&nbsp;--&nbsp;";
			}
			return new Line
			{
				LineNumber = 3,
				LineContents = line
			};
		}

		protected override Line LineFour(NumericDisplayBlock block)
		{
			var lineString = new StringBuilder();
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.LowerLeft).IsOn.Equals(true))
			{
				lineString.Append("|&nbsp;&nbsp;&nbsp;");
			}
			else
			{
				lineString.Append("&nbsp;&nbsp;&nbsp;");
			}
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.LowerRight).IsOn.Equals(true))
			{
				lineString.Append("|");
			}
			else
			{
				lineString.Append("&nbsp;");
			}
			return new Line
			{
				LineNumber = 4,
				LineContents =  lineString.ToString()
			};
		}

		protected override Line LineFive(NumericDisplayBlock block)
		{
			var line = "&nbsp;&nbsp;&nbsp;&nbsp;";
			if(block.IntegerMap.BlockSegments.First(bs=>bs.SegmentPosition==SegmentPosition.Bottom).IsOn.Equals(true))
			{
				line = "&nbsp;--&nbsp;";
			}
			return new Line
			{
				LineNumber = 5,
				LineContents = line
			};
		}
		#endregion 

		public Dictionary<int,StringBuilder> GetHtmlLineConent()
		{
			var lineOne		= new StringBuilder();
			var lineTwo		= new StringBuilder();
			var lineThree	= new StringBuilder();
			var lineFour	= new StringBuilder();
			var lineFive	= new StringBuilder();

			foreach(var webContent in _webRenderContents)
			{
				lineOne.Append(webContent.Lines.First(l => l.LineNumber==1).LineContents);
				lineTwo.Append(webContent.Lines.First(l => l.LineNumber==2).LineContents);
				lineThree.Append(webContent.Lines.First(l => l.LineNumber==3).LineContents);
				lineFour.Append(webContent.Lines.First(l => l.LineNumber==4).LineContents);
				lineFive.Append(webContent.Lines.First(l => l.LineNumber==5).LineContents);
			}	
		}
	}


}
