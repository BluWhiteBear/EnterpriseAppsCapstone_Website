namespace Breadcrumbs.Models
{
    public class Stats
    {
        // Count of items in AspNetUsers
        public int UserCount { get; set; }
        // Count of items in Locations
        public int LocationCount { get; set; }
        // Count of items in Destinations
        public int DestinationCount { get; set; }
        // Name of location with most destinations
        public string MostDestinations { get; set; }
    }
}
