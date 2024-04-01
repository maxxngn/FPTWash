using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class PackagesOrder
{
    public int Id { get; set; }

    public int? PackageId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? Price { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Package? Package { get; set; }
}
