using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }

    public string? Picture { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
