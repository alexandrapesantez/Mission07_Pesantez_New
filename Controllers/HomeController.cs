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
        public IActionResult Form(Application response) 
        {
            _context.Applications.Add(response);// add record to the databse 
            _context.SaveChanges(); // save changes to the database
            return View("Confirmation"); 
        }

        public IActionResult movieCollection()
        {
            var applications = _context.Applications
            .Where(x => x.Year < 1888)
            .OrderBy(x => x.Title).ToList(); 

            return View(applications);  
        }
    }

}
