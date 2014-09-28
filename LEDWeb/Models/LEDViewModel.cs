using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Services;

namespace LEDWeb.Models {
	public class LEDViewModel 
	{
		public string UserInput { get; set; }

		public bool IsInputValid { get; set; }

		public string RowOneContents { get; set; }
		public string RowTwoContents { get; set; }
		public string RowThreeContents { get; set; }
		public string RowFourContents { get; set; }
		public string RowFiveContents { get; set; }
	}
}