using Microsoft.AspNetCore.Mvc;

namespace buoi3.Controllers
{
    public class Hello : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hello()
        {
            return View();
        }
    }
}
