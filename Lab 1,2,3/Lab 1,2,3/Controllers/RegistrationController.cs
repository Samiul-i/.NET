using Lab_1_2_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1_2_3.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: Receive and validate the submitted form 
        [HttpPost]
        public IActionResult Register(Student student)
        {
            // Check for duplicate student ID manually 
            if (student.StudentId == "STU001")
            {
                ModelState.AddModelError("StudentId",
                "Student ID STU001 is already registered");
            }
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            ViewBag.Message = "Registration successful for " + student.Name;
            return View("Success", student);
        }
    }
}
