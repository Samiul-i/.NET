using Microsoft.AspNetCore.Mvc;

namespace Lab_1_2_3.Controllers
{
    public class CourseController : Controller
    {
       
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "All Courses";
            return View();
        }

     
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.CourseId = id;
            return View();
        }

        public IActionResult Search(string keyword)
        {
            ViewBag.Keyword = keyword;
            return View();
        }
    }
}
