using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Services {
	public class WebValidation
	{
		private readonly InputHandler _inputHandler = new InputHandler();
	//	public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata,ControllerContext context) {
	//	throw new NotImplementedException();
	//	}

	//	public override bool ValidationResult
	//	protected override ValidationResult IsValid(object value, ValidationContext validationContext)
	//	{
	//		if (!_inputHandler.IsInputValid(value.ToString()))
	//		{
	//			return new ValidationResult("input invalid");
	//		};
			
	//		return ValidationResult.Success;
	//	}

	//(object value)
	//	{
	//		return _inputHandler.IsInputValid(value.ToString());
	//	}


	}
}
