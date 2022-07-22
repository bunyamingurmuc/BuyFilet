using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.WebUI.Controller
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
