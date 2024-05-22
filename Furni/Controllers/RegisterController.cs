using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
		public IActionResult Login()
        {
            return View();
        }
    }
}
