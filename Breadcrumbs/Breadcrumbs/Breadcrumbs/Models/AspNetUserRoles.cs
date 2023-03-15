﻿using System;
using System.Collections.Generic;

namespace Breadcrumbs.Models
{
    public partial class AspNetUserRoles
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }

        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        public virtual ICollection<AspNetUser> Users { get; set; }
    }
}
