using Microsoft.AspNetCore.Mvc;

namespace MVC5_mockup.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
