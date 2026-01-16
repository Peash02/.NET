using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
