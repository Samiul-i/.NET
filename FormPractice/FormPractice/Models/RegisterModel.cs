using Microsoft.AspNetCore.Mvc;

namespace FormPractice.Models
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
