using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Services;

namespace LEDWeb.Models {
	public class LEDViewModel 
	{
		public string UserInput { get; set; }

		public bool InputIsValid { get; set; }

		public Dictionary<int,StringBuilder> RowContents = new Dictionary<int, StringBuilder>(); 

	}
}