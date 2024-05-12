using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
