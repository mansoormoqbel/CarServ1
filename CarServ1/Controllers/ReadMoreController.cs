using Microsoft.AspNetCore.Mvc;

namespace CarServ1.Controllers
{
    public class ReadMoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DiagnosticTest()
        {
            return View();
        }
        public IActionResult EngineServicing()
        {
            return View();
        }
        public IActionResult TiresReplacement()
        {
            return View();
        }
        public IActionResult OilChanging()
        {
            return View();
        }
        public IActionResult KIA()
        {
            return View();
        }
    }
}
