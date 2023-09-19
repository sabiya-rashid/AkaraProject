using Microsoft.AspNetCore.Mvc;

namespace AkaraProject.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
