using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class ItemType
{
    public long Id { get; set; }

    public string TypeName { get; set; } = null!;

    public long? MenuId { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Menu? Menu { get; set; }
}
