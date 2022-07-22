using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.WebUI.Controller
{
    public class CheckOutController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
       
    }
}
