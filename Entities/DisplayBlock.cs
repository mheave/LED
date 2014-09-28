using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Entities;

namespace Models
{
	public class NumericDisplay
	{
		public List<NumericDisplayBlock> Blocks = new List<NumericDisplayBlock>();
	}

	public class NumericDisplayBlock
	{
		public int BlockPosition { get; set; }
		public IntegerMap IntegerMap { get; set; }

		public NumericDisplayBlock() { }

		public NumericDisplayBlock(int blockPosition, IntegerMap integerMap)
		{
			BlockPosition = blockPosition;
			IntegerMap = integerMap;
		}

		
	}
		
	public class DisplayBlockSegment
	{
		public SegmentPosition SegmentPosition { get; set; }

		public bool IsOn { get; set; }

	}

	public enum SegmentPosition
	{
		Bottom = 0,
		LowerLeft = 1,
		UpperLeft = 2,
		Top = 3,
		UpperRight = 4,
		LowerRight = 5,
		Middle = 6,
	}
}

