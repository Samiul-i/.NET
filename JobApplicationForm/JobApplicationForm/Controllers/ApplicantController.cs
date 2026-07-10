using JobApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobApplicationForm.Controllers
{
    public class ApplicantController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Applicant)
        {
            if (!ModelState.IsValid)
            {
                return View(Applicant);
            }
        }
    }
}
