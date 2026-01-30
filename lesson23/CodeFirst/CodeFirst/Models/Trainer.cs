using System;
using System.Collections.Generic;

namespace CodeFirst.Models;

public partial class Trainer
{
    public int TrainerId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
