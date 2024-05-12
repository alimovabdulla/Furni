using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
