using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? PickupDate { get; set; }

    public decimal? Weight { get; set; }

    public string? Status { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
