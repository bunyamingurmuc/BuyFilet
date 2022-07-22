using Buyfilet.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.TEST.WebUI.Controllers
{
    public class TestController : Controller
    {
        private readonly IBFUserService _bfUserService;

        public TestController(IBFUserService bfUserService)
        {
            _bfUserService = bfUserService;
        }
        public async Task<IActionResult> GetAllProducts()
        {
            var response=await _bfUserService.GetAllAsync();
            var users = response.Data;
            return View(users);
        }
    }
}
