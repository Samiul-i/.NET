using Microsoft.AspNetCore.Mvc;

namespace Lab_1_2_3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
