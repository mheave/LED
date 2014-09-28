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
				ledViewModel.IsInputValid = true;
			}

			return View(ledViewModel);
		}

    }
}
