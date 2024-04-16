using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Blog
{
    public long Id { get; set; }

    public DateTime? DateImport { get; set; }

    public string? Title { get; set; }

    public string? ShortTitle { get; set; }

    public string? Picture { get; set; }

    public string? Describe { get; set; }
}
