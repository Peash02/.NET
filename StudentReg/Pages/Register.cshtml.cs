using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRegistration.Models;

namespace StudentRegistration.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = $"Student Registered Successfully.";
            }

        }
    }
}
