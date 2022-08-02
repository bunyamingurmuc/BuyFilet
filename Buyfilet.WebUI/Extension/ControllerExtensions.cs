using System.Text;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.WebUI.Extension
{
    public static class ControllerExtensions
    {
        public static IActionResult ResponseRedirectAction<T>(this Microsoft.AspNetCore.Mvc.Controller controller,
            IResponse<T> response, string actionName, string controllerName = "")
        {
            if (response.ResponseType==ResponseType.NotFound)
            {
                return controller.NotFound();
            }

            if (response.ResponseType==ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    controller.ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                return controller.View(response.Data);
            }

            if (string.IsNullOrWhiteSpace(controllerName))
            {
                return controller.RedirectToAction(actionName);
            }
            else
            {
                return controller.RedirectToAction(actionName, controllerName);
            }
        }

        public static IActionResult ResponseView<T>(this Microsoft.AspNetCore.Mvc.Controller controller,
            IResponse<T> response)
        {
            if (response.ResponseType==ResponseType.NotFound)
            {
                return controller.NotFound();
            }

            return controller.View(response.Data);
        }

        public static IActionResult ResponseRedirectAction(this Microsoft.AspNetCore.Mvc.Controller controller,
            IResponse response, string actionName)
        {
            if (response.ResponseType==ResponseType.NotFound)
            {
                return controller.NotFound();
            }

            return controller.RedirectToAction(actionName);
        }
    }
}
