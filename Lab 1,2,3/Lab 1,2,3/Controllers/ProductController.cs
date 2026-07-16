using Microsoft.AspNetCore.Mvc;

namespace Lab_1_2_3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string category,int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;
            return View();
        }
    }
}
