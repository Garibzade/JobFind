using Microsoft.AspNetCore.Mvc;

namespace JobFind.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
