using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class SudNews
{
    public int Id { get; set; }

    public int? NewId { get; set; }

    public string? SubTitle { get; set; }

    public string? SubImage { get; set; }

    public string? SubConnect { get; set; }

    public string? SubContent { get; set; }

    public virtual News? New { get; set; }
}
