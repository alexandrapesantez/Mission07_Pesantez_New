using Mission06_Pesantez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission06_Pesantez.Controllers
{
    public class HomeController : Controller
    {
        private JoelContext _context; 
        public HomeController(JoelContext temp) // constructor 
        {
            _context = temp; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get_to_Know_Joel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Movie response) 
        {
            _context.Movies.Add(response);// add record to the databse 
            _context.SaveChanges(); // save changes to the database
            return View("Confirmation"); 
        }

        public IActionResult movieCollection()
        {
            var movies = _context.Movies.ToList();

            return View(movies);  
        }
    }

}
