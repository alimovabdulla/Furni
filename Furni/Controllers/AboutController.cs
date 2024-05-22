 
using Furni.DataBAse;
using Furni.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Furni.Controllers
{
	public class AboutController : Controller
	{
         
        private readonly FurniContext _furnicontext;
		public AboutController(  FurniContext context)
		{
			 
			_furnicontext = context;
		}
		public IActionResult Index()
		{
			 
			List<Team> data =   _furnicontext.Teams.ToList();
			return View(data);


		}
		[HttpGet]
		public IActionResult Create()
		{
			 
			return View();

		}
		[HttpPost]
		public IActionResult Create(Team team)
		{

			_furnicontext.Teams.Add(team);

			_furnicontext.SaveChanges();

		  return RedirectToAction("Index", "About");	
		}
		public IActionResult Edit( )
		{

			 List<Team> teams = _furnicontext.Teams.ToList();
			return View(teams);




		}
		[HttpGet]
		public IActionResult  Update( int Id)
		{

			Team existteam = _furnicontext.Teams.FirstOrDefault(x=>x.id == Id);
			return View(existteam);





		}
		public IActionResult Update(Team newteam)
		{
			Team oldteam = _furnicontext.Teams.FirstOrDefault(x=>x.id==newteam.id);
			oldteam.Status = newteam.Status;
			oldteam.Name = newteam.Name;
			oldteam.Description= newteam.Description;
			oldteam.ImgUrl= newteam.ImgUrl;
			_furnicontext.SaveChanges();

			return RedirectToAction("edit");




		}

		public IActionResult Delete(int id)
		{



			Team team = _furnicontext.Teams.FirstOrDefault(x => x.id == id);
		   _furnicontext.Teams.Remove(team);
			_furnicontext.SaveChanges( );
			return RedirectToAction("edit");

		}

	}


}
