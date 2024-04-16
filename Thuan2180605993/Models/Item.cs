using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Item
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal? PurcharsePrice { get; set; }

    public decimal SellPrice { get; set; }

    public DateTime? DateImport { get; set; }

    public int? Quantity { get; set; }

    public long? TypeId { get; set; }

    public long? BrandId { get; set; }

    public string? Picture { get; set; }

    public bool? Active { get; set; }

    public string? ShortTitle { get; set; }

    public string? Describe { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ItemType? Type { get; set; }
}
