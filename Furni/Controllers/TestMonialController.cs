using Furni.DataBAse;
using Furni.Entities;
using Furni.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Furni.Controllers
{
    public class TestMonialController : Controller
    {
        private readonly FurniContext _furniContext;
        public TestMonialController(FurniContext context )
        {
            _furniContext = context;  
        }
        [HttpGet]
        public IActionResult Create()
        {
             
            return View();
       
        }

        [HttpPost]
        public IActionResult Create(TestiMonials testiMonials)
        
        {
            _furniContext.TestiMonial.Add(testiMonials);
             _furniContext.SaveChanges();
            return  RedirectToAction( "edit", "TestMonial");  



        }
        
        public IActionResult Edit(TestiMonials testi)
        {


            HomeViewModel homeViewModel = new HomeViewModel();
            List<TestiMonials> testis = _furniContext.TestiMonial.ToList();
             homeViewModel.testiMonials = testis;
            return View(homeViewModel);





        }
        [HttpGet]
        public IActionResult Update(int Id)
        {


            TestiMonials existTesti = _furniContext.TestiMonial.FirstOrDefault(x => x.id == Id);
          

            return View(existTesti);
        }
        [HttpPost]
        public IActionResult Update(TestiMonials newt)
        {
            
            TestiMonials oldTestimoni =  _furniContext.TestiMonial.FirstOrDefault(x=>x.id==newt.id);
            newt.Name = oldTestimoni.Name;
            newt.Description = oldTestimoni.Description;
            newt.ImgUrl = oldTestimoni.ImgUrl;
            newt.Status = oldTestimoni.Status;
            _furniContext.SaveChanges();
            return RedirectToAction("edit","TestMonial");



        }
        [HttpGet]

        public IActionResult Delete(int Id) 
        
        {
            TestiMonials testiMonials = _furniContext.TestiMonial.FirstOrDefault(x => x.id == Id);
            _furniContext.TestiMonial.Remove(testiMonials);
            _furniContext.SaveChanges();

            return RedirectToAction("edit", "TestMonial");
        
        
        
        
        
        }
    }
}
