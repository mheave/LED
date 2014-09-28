using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Models
{
	public static class IntegerMaps
	{
		public static Dictionary<int, IntegerMap> Maps = IntegerMapFactory.AllIntegerMaps();

		public static IntegerMap GetMapForInteger(int integer)
		{
			if (integer>=0 && integer<10)
			{
				return Maps.First(m => m.Key == integer).Value;
			}
			throw new Exceptions.IntegerOutOfRangeException();
		}
	}

	public class IntegerMap
	{
		public int RepresentedNumber { get; set;}

		public List<DisplayBlockSegment> BlockSegments = new List<DisplayBlockSegment>();

		public IntegerMap(int representedNumber)
		{
			RepresentedNumber = representedNumber;
		}		
	}


	public static class IntegerMapFactory
	{	
		private static Dictionary<int, IntegerMap> CreateAllIntegerMaps()
		{
			var allMaps = new Dictionary<int, IntegerMap>();

			var zero = new IntegerMap(0);
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			zero.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = false});	
			allMaps.Add(0, zero);

			var one = new IntegerMap(1);
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = false});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = false});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = false});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			one.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = false});	
			allMaps.Add(1, one);	

			var two = new IntegerMap(2);
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = true});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = false});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = false});
			two.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(2, two);

			var three = new IntegerMap(3);
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = false});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			three.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(3, three);

			var four = new IntegerMap(4);
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = false});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = false});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			four.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(4, four);

			var five = new IntegerMap(5);
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = false});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			five.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(5, five);			

			var six = new IntegerMap(6);
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = true});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = false});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			six.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(6, six);	
		
			var seven = new IntegerMap(7);
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = false});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = false});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			seven.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = false});	
			allMaps.Add(7, seven);	

			var eight = new IntegerMap(8);
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			eight.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(8, eight);	

			var nine = new IntegerMap(9);
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Bottom, IsOn = false});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerLeft, IsOn = false});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperLeft, IsOn = true});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Top, IsOn = true});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.UpperRight, IsOn = true});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.LowerRight, IsOn = true});
			nine.BlockSegments.Add(new DisplayBlockSegment{SegmentPosition = SegmentPosition.Middle, IsOn = true});	
			allMaps.Add(9, nine);	

			return allMaps;
		}

		public static Dictionary<int, IntegerMap> AllIntegerMaps()
		{
			return CreateAllIntegerMaps();
		}
	}


	
}
