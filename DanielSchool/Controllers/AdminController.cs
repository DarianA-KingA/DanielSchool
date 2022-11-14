using Microsoft.AspNetCore.Mvc;

namespace DanielSchool.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
