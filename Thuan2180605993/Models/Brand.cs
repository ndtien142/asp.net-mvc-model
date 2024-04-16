using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Brand
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long? MenuId { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Menu? Menu { get; set; }
}
