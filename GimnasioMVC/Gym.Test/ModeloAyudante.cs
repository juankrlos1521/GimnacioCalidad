using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Gym.Test
{
    public static class MModeloAyudante
    {
        public static void ValidateModel(this Controller controller, object viewModel)
        {
            controller.ModelState.Clear();

            var validationContext = new ValidationContext(viewModel, null, null);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(viewModel, validationContext, validationResults, true);

            foreach (var result in validationResults)
            {
                if (result.MemberNames.Any())
                {
                    foreach (var name in result.MemberNames)
                    {
                        controller.ModelState.AddModelError(name, result.ErrorMessage);
                    }
                }
                else
                {
                    controller.ModelState.AddModelError("Fallo Validación", result.ErrorMessage);
                }
            }
        }
    }
}
