using System.ComponentModel.DataAnnotations
namespace JobApplicationForm.Models
{
    public class Applicant
    {
        [Required(ErrorMessage="Name is Required")]
        [StringLength(70,MinimumLength =3,ErrorMessage ="Name must be between 3 to 70 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Position is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter a position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Year of experience is Required")]
        [Range(0,40, ErrorMessage = "Enter Year of experience")]
        public double YearOfExperience { get; set; }

        [Required(ErrorMessage = "Salary is Required")]
        [Range(10000,500000, ErrorMessage = "enter expected salary")]
        public int Salary { get; set; }

    }
}
