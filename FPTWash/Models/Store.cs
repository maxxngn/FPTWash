using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Store
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
