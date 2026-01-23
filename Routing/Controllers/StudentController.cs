using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class StudentController : Controller
    {
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return Content("Student ID is: " + id);
        }

        [Route("Marks/{id}/{subject}")]
        //Multiple Route parameters
        public IActionResult Marks(int id , string subject)
        {
            return Content($"Student Id:{id}. Subject : {subject}. ");
        }

        [Route("Input/{id}")]
        public IActionResult Input(int id , string name)
        {
            string message = $"Student Id:{id}, Student Name: {name}";
            return Content(message);
        }
    }
}
