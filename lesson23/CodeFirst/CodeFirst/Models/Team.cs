using System;
using System.Collections.Generic;

namespace CodeFirst.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string Name { get; set; } = null!;

    public int? TrainerId { get; set; }

    public int? Rate { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();

    public virtual Trainer? Trainer { get; set; }
}
