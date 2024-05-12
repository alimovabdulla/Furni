using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
