using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Package
{
    public int Id { get; set; }

    public decimal? Price { get; set; }

    public int? Count { get; set; }

    public virtual ICollection<PackagesOrder> PackagesOrders { get; set; } = new List<PackagesOrder>();
}
