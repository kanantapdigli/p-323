using Microsoft.AspNetCore.Mvc;

namespace p323.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            TempData["test"] = "test";
            ViewBag.Name = "name";
            return RedirectToAction("Test");
        }

        public IActionResult Test()
        {
            var test = TempData["test"];
            var name = ViewBag.Name;

            return Ok();
        }
    }
}
