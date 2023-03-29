using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Breadcrumbs.Models;

namespace Breadcrumbs.Controllers
{
    public class StatsController : Controller
    {
        private readonly breadcrumbsContext _context;

        public StatsController(breadcrumbsContext context)
        {
            _context = context;
        }
        
        // return the count of all locations
        public async Task<IActionResult> Index()
        {
            var stats = new Stats();
            // Overview
            stats.LocationCount = await _context.Locations.CountAsync();
            stats.DestinationCount = await _context.Destinations.CountAsync();
            stats.UserCount = await _context.AspNetUsers.CountAsync();

            // Returns the location with the highest number of attached destinations
            stats.MostDestinations = await _context.Locations
                .OrderByDescending(l => l.Destinations.Count)
                .Select(l => l.LocationName)
                .FirstOrDefaultAsync();

            return View(stats);
        }
    }
}
