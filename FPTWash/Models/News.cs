﻿using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class News
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Imgae { get; set; }

    public virtual ICollection<SudNews> SudNews { get; set; } = new List<SudNews>();
}
