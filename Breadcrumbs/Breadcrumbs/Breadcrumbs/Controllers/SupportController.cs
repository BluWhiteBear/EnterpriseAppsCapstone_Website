using Microsoft.AspNetCore.Mvc;

namespace Breadcrumbs.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
