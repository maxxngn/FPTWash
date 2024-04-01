using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? Message { get; set; }

    public virtual Order? Order { get; set; }
}
