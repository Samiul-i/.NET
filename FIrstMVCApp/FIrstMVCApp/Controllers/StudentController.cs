using Microsoft.AspNetCore.Mvc;

namespace FIrstMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student List";
            ViewBag.Message = "Welcome to the Student Module";

            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentID = id;
            return View();
        }

        public IActionResult About()
        {
            return Content("This is the student module.");
        }
    }
}
