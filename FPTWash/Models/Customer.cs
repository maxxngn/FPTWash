﻿using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Phone { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Password { get; set; }

    public int? IsAdmin { get; set; }

    public int? Count { get; set; }

    public virtual ICollection<PackagesOrder> PackagesOrders { get; set; } = new List<PackagesOrder>();
}