using System;
using System.Collections.Generic;

namespace Breadcrumbs.Models
{
    public partial class Destination
    {
        public int DestinationId { get; set; }
        public string? DestinationName { get; set; }
        public string? DestinationTag { get; set; }
        public string? Directions { get; set; }
        public int? LocationId { get; set; }
        public int? ImgId { get; set; }
        public int? UserId { get; set; }

        public virtual Location? Location { get; set; }
    }
}
