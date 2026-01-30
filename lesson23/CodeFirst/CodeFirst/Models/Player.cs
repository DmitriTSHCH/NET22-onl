using System;
using System.Collections.Generic;

namespace CodeFirst.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string Name { get; set; } = null!;

    public int? TeamId { get; set; }

    public int? Age { get; set; }

    public int? Salary { get; set; }

    public virtual Team? Team { get; set; }
}
