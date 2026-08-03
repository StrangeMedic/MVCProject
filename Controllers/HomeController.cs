using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutApplication()
        {
            return View("Application");
        }

        [HttpPost]
        public IActionResult FillOutApplication(App response)
        {
            return View("Confirm", response);
        }
    }
}
