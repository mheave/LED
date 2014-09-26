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

		public IntegerMap(int representedNumber)
		{
			RepresentedNumber = representedNumber;
		}

		public Dictionary<SegmentPosition, bool> BlockMap = new Dictionary<SegmentPosition, bool>();

		public void SetImageMapSegment(SegmentPosition position, bool isOn)
		{
			if (BlockMap.ContainsKey(position))
			{
				BlockMap[position] = isOn;
			}
			else
			{
				BlockMap.Add(position, isOn);
			}
		}

	}


	public static class IntegerMapFactory
	{	
		private static Dictionary<int, IntegerMap> CreateAllIntegerMaps()
		{
			var allMaps = new Dictionary<int, IntegerMap>();

			var zero = new IntegerMap(0);
			zero.SetImageMapSegment(SegmentPosition.Bottom, true);
			zero.SetImageMapSegment(SegmentPosition.LowerLeft, true);
			zero.SetImageMapSegment(SegmentPosition.MiddleLeft, true);
			zero.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			zero.SetImageMapSegment(SegmentPosition.Top, true);
			zero.SetImageMapSegment(SegmentPosition.UpperRight, true);
			zero.SetImageMapSegment(SegmentPosition.MiddleRight, true);		
			zero.SetImageMapSegment(SegmentPosition.LowerRight, true);
			zero.SetImageMapSegment(SegmentPosition.Middle, false);			
			allMaps.Add(0, zero);

			var one = new IntegerMap(1);
			one.SetImageMapSegment(SegmentPosition.Bottom, false);
			one.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			zero.SetImageMapSegment(SegmentPosition.MiddleLeft, false);
			one.SetImageMapSegment(SegmentPosition.UpperLeft, false);
			one.SetImageMapSegment(SegmentPosition.Top, false);
			one.SetImageMapSegment(SegmentPosition.UpperRight, true);
			zero.SetImageMapSegment(SegmentPosition.MiddleRight, true);
			one.SetImageMapSegment(SegmentPosition.LowerRight, true);
			one.SetImageMapSegment(SegmentPosition.Middle, false);
			allMaps.Add(1, one);

			var two = new IntegerMap(2);
			two.SetImageMapSegment(SegmentPosition.Bottom, true);
			two.SetImageMapSegment(SegmentPosition.LowerLeft, true);
			two.SetImageMapSegment(SegmentPosition.UpperLeft, false);
			two.SetImageMapSegment(SegmentPosition.Top, true);
			two.SetImageMapSegment(SegmentPosition.UpperRight, true);
			two.SetImageMapSegment(SegmentPosition.LowerRight, false);
			two.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(2, two);

			var three = new IntegerMap(3);
			three.SetImageMapSegment(SegmentPosition.Bottom, true);
			three.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			three.SetImageMapSegment(SegmentPosition.UpperLeft, false);
			three.SetImageMapSegment(SegmentPosition.Top, true);
			three.SetImageMapSegment(SegmentPosition.UpperRight, true);
			three.SetImageMapSegment(SegmentPosition.LowerRight, true);
			three.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(3, three);

			var four = new IntegerMap(4);
			four.SetImageMapSegment(SegmentPosition.Bottom, false);
			four.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			four.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			four.SetImageMapSegment(SegmentPosition.Top, false);
			four.SetImageMapSegment(SegmentPosition.UpperRight, true);
			four.SetImageMapSegment(SegmentPosition.LowerRight, true);
			four.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(4, four);

			var five = new IntegerMap(5);
			five.SetImageMapSegment(SegmentPosition.Bottom, true);
			five.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			five.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			five.SetImageMapSegment(SegmentPosition.Top, true);
			five.SetImageMapSegment(SegmentPosition.UpperRight, false);
			five.SetImageMapSegment(SegmentPosition.LowerRight, true);
			five.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(5, five);

			var six = new IntegerMap(6);
			six.SetImageMapSegment(SegmentPosition.Bottom, true);
			six.SetImageMapSegment(SegmentPosition.LowerLeft, true);
			six.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			six.SetImageMapSegment(SegmentPosition.Top, true);
			six.SetImageMapSegment(SegmentPosition.UpperRight, false);
			six.SetImageMapSegment(SegmentPosition.LowerRight, true);
			six.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(6, six);

			var seven = new IntegerMap(7);
			seven.SetImageMapSegment(SegmentPosition.Bottom, false);
			seven.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			seven.SetImageMapSegment(SegmentPosition.UpperLeft, false);
			seven.SetImageMapSegment(SegmentPosition.Top, true);
			seven.SetImageMapSegment(SegmentPosition.UpperRight, true);
			seven.SetImageMapSegment(SegmentPosition.LowerRight, true);
			seven.SetImageMapSegment(SegmentPosition.Middle, false);
			allMaps.Add(7, seven);

			var eight = new IntegerMap(8);
			eight.SetImageMapSegment(SegmentPosition.Bottom, true);
			eight.SetImageMapSegment(SegmentPosition.LowerLeft, true);
			eight.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			eight.SetImageMapSegment(SegmentPosition.Top, true);
			eight.SetImageMapSegment(SegmentPosition.UpperRight, true);
			eight.SetImageMapSegment(SegmentPosition.LowerRight, true);
			eight.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(8, eight);

			var nine = new IntegerMap(9);
			nine.SetImageMapSegment(SegmentPosition.Bottom, false);
			nine.SetImageMapSegment(SegmentPosition.LowerLeft, false);
			nine.SetImageMapSegment(SegmentPosition.UpperLeft, true);
			nine.SetImageMapSegment(SegmentPosition.Top, true);
			nine.SetImageMapSegment(SegmentPosition.UpperRight, true);
			nine.SetImageMapSegment(SegmentPosition.LowerRight, true);
			nine.SetImageMapSegment(SegmentPosition.Middle, true);
			allMaps.Add(9, nine);
			
			return allMaps;
		}

		public static Dictionary<int, IntegerMap> AllIntegerMaps()
		{
			return CreateAllIntegerMaps();
		}
	}


	
}
