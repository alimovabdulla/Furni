using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
