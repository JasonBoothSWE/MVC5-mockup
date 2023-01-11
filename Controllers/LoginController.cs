using Microsoft.AspNetCore.Mvc;

namespace MVC5_mockup.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToPage("Login");
        }
    }
}
