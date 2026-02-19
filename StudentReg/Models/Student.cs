using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Za-z]+$",
            ErrorMessage = "Name must contain only alphabets.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^[0-9]+$",
            ErrorMessage = "ID must contain only numbers.")]
        public string ID { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60.")]
        public int Age { get; set; }
    }
}
