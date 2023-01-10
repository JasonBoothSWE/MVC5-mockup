using Microsoft.AspNetCore.Mvc;

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
    }
}
