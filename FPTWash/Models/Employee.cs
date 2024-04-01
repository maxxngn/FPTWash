using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? StoreId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public string? Rank { get; set; }

    public virtual Store? Store { get; set; }
}
