using System;
using System.Collections.Generic;

namespace Thuan2180605993.Models;

public partial class Admin
{
    public string Username { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Picture { get; set; }
}
