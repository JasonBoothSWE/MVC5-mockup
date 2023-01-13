using Microsoft.AspNetCore.Mvc;

namespace MVC5_mockup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Devices()
        {
            return Redirect("https://localhost:7176/swagger/index.html");
        }
    }
}
