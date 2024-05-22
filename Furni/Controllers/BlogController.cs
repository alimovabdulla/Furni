using Furni.DataBAse;
using Furni.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Furni.Controllers
{
    public class BlogController : Controller
    {


        private readonly FurniContext _context;

        public BlogController(FurniContext context)
        {

            _context = context;


        }
        public IActionResult Index()
        {
            List<Blog> data = _context.Blogs.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Creat()
        {



            return View();
        }
        [HttpPost]
        public IActionResult Creat(Blog blog)
        {

            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(Blog blog)
        {


            List<Blog> blogs = _context.Blogs.ToList();

            return View(blogs);
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            Blog existblog = _context.Blogs.FirstOrDefault(x => x.id == Id);


            return View(existblog);

        }
        public IActionResult Update(Blog newBlog)
        {

            Blog oldBlog = _context.Blogs.FirstOrDefault(x => x.id == newBlog.id);
            oldBlog.Description = newBlog.Description;
            oldBlog.ImgUrl = newBlog.ImgUrl;
            oldBlog.By = newBlog.By;

            _context.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {

            Blog blog = _context.Blogs.FirstOrDefault(b => b.id == Id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges(); return RedirectToAction("edit");



        }
    }
}
