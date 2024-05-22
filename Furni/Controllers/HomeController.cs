using Furni.DataBAse;
using Furni.Entities;
using Furni.Models;
using Furni.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Furni.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly FurniContext _furnicontext;
		public HomeController(ILogger<HomeController> logger , FurniContext context)
		{
			_logger = logger;
			_furnicontext = context;
		}

		public IActionResult Index()
		{
			HomeViewModel model = new HomeViewModel();
			List<Cart> data = _furnicontext.Carts.ToList();

            List<TestiMonials> testis = _furnicontext.TestiMonial.ToList();
			model.cart = data;
			model.testiMonials = testis;

            return View(model);
		}
	 
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
