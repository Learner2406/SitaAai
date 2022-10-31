using Microsoft.AspNetCore.Mvc;

namespace SitaAai.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }
    }
}
