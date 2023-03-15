using Microsoft.AspNetCore.Mvc;

namespace Breadcrumbs.Controllers
{
    public class StatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
