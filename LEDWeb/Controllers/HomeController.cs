using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LEDWeb.Models;
using Services;

namespace LEDWeb.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
			var ledViewModel = new LEDViewModel();
            return View(ledViewModel);
        }

		[HttpPost]
		public ActionResult Index(LEDViewModel ledViewModel) 
		{
			var _inputHandler = new InputHandler();
			if (_inputHandler.IsInputValid(ledViewModel.UserInput)) {
				ledViewModel.InputIsValid = true;				
				var webRender = new WebRender(int.Parse(ledViewModel.UserInput));
				webRender.RenderDisplay(int.Parse(ledViewModel.UserInput));
				ledViewModel.RowContents = webRender.ViewModelRowContent;
			}

			return View(ledViewModel);
		}

    }
}
