using Microsoft.AspNetCore.Mvc;

namespace SitaAai.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
