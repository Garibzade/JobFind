using Microsoft.AspNetCore.Mvc;

namespace JobFind.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
