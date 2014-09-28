using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Services;

namespace LEDWeb.Models {
	public class LEDViewModel 
	{
		[WebValidation]
		public string UserInput { get; set; }
	}
}