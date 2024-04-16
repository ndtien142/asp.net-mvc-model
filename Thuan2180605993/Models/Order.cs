using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Order
{
    public long Id { get; set; }

    public DateTime? Orderdate { get; set; }

    public bool? Deliverystatus { get; set; }

    public DateTime? Deliverydate { get; set; }

    public bool? Status { get; set; }

    public decimal? Totalprice { get; set; }

    public long? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
