using Microsoft.AspNetCore.Mvc;
using MVC5_mockup.Models;
using System.Diagnostics;

namespace MVC5_mockup.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
