using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.WebUI.Controller
{
    public class PageController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }
    }
}
