using System;
using System.Collections.Generic;

namespace Breadcrumbs.Models
{
    public partial class Location
    {
        public Location()
        {
            Destinations = new HashSet<Destination>();
        }

        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public int? StreetNumber { get; set; }
        public string? RoadName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }
        public string? LocationTag { get; set; }
        public int? ImgId { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
