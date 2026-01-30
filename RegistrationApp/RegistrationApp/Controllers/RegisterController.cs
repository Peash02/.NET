using Microsoft.AspNetCore.Mvc;

namespace RegistrationApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Register user)
        {
            if (ModelState.IsValid)
            {
                return Content($"Registration Successful\n Name:{user.Name}\n Email:{user.Email}\n Password:{user.Password}\n Age:{user.Age}");

            }

            return View(user);
        }
    }
}
