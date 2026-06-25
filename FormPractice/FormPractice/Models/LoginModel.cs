using Microsoft.AspNetCore.Mvc;

namespace FormPractice.Models
{
    public class LoginController : Controller
    {
        public required string Username {  get; set; }
        public required string Password { get; set; }
        
    }
}
