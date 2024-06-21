using Microsoft.AspNetCore.Mvc;

namespace JobFind.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
