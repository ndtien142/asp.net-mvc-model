using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Payment
{
    public long Id { get; set; }

    public decimal? Payprices { get; set; }

    public long? OrderId { get; set; }

    public virtual Order? Order { get; set; }
}
