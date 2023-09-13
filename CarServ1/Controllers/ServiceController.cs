using Microsoft.AspNetCore.Mvc;

namespace CarServ1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
        public IActionResult Technicians()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
