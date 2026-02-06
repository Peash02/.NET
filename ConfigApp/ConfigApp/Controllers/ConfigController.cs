using Microsoft.AspNetCore.Mvc;

namespace ConfigApp.Controllers
{
    public class ConfigController : Controller
    {
        private readonly IConfiguration _configuration;
        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.AppName = 
                _configuration["AppSettings:ApplicationName"];

            ViewBag.Version =
                _configuration["AppSettings:Version"];

            ViewBag.Developer =
                _configuration["AppSettings:Developer"];
            return View();
        }
    }
}
