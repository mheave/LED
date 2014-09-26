using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
	public class Exceptions 
	{
		public class IntegerOutOfRangeException : Exception
		{
			public IntegerOutOfRangeException() : base("Integer value must be between 0 and 9")
			{
				
			}
		}
		
	}
}
