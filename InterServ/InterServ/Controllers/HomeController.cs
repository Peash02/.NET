using System.Diagnostics;
using InterServ.Models;
using InterServ.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterServ.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnything _serv;

        public HomeController(IAnything serv)
        {
            _serv = serv;
        }

        public IActionResult Index()
        {
            var msg = _serv.DisplayMsg("blah blah blah");
            ViewBag.Message = msg;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
