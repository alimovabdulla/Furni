using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
	public class OperationsController : Controller
	{
		  
		public IActionResult Index()
		{
			return View();
		}
	}
}
