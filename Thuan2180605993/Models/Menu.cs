using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Menu
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Link { get; set; }

    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();

    public virtual ICollection<ItemType> ItemTypes { get; set; } = new List<ItemType>();
}
