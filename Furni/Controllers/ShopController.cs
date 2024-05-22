using Furni.DataBAse;
using Furni.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furni.Controllers
{
	public class ShopController : Controller
	{
		private readonly FurniContext _context;
        public ShopController(FurniContext context)
        {
				 _context = context;
        }
        public IActionResult Index()
		{
			List<Product> data = _context.Products.ToList();
			return View(data);
		}
		[HttpGet]
		public IActionResult Create()
		{ 
		 
		
		  return View();
 
		
		}
		[HttpPost]
		public IActionResult Create(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
			return View();

		}
		[HttpGet]
		public IActionResult Edit(Product product)
		{



			List<Product> data = _context.Products.ToList();
			return View(data);
		}
		[HttpGet]
		public IActionResult  Update(int Id)
		{
			Product existproduct = _context.Products.FirstOrDefault(x => x.id == Id);


			return View(existproduct);

		}
		public IActionResult Update(Product newProduct)
		{

			Product oldProduct = _context.Products.FirstOrDefault(x => x.id == newProduct.id);
			oldProduct.Name= newProduct.Name;
			oldProduct.Description= newProduct.Description;
			oldProduct.CostPrice= newProduct.CostPrice;
			oldProduct.SalePrice= newProduct.SalePrice;
			oldProduct.StockCount= newProduct.StockCount;
			oldProduct.ImgUrl= newProduct.ImgUrl;
			_context.SaveChanges();
			return RedirectToAction("Index");
		    

		}
		[HttpGet]
		public IActionResult Delete(int Id) 
		{



			Product Product = _context.Products.FirstOrDefault(x => x.id ==Id);

			_context.Products.Remove(Product);
			_context.SaveChanges();
			return RedirectToAction("edit");
		}

	}
}
