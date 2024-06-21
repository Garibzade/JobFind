using Microsoft.AspNetCore.Mvc;

namespace JobFind.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
