using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class OrderDetail
{
    public long Id { get; set; }

    public int Quantity { get; set; }

    public long? ItemId { get; set; }

    public long? OrderId { get; set; }

    public decimal? Totalprice { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Order? Order { get; set; }
}
