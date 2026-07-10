using Microsoft.AspNetCore.Mvc;

namespace Lab_1_2_3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student List";
            ViewBag.Message = "Welcome to the student module";
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        public IActionResult About()
        {
            return Content("This is the student module");
        }
    }      
    
}
