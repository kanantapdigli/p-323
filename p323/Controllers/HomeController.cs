using Microsoft.AspNetCore.Mvc;

namespace p323.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
