using System;
using System.Collections.Generic;

namespace SM.Infrastructure.Persistance.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Status1 { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();
}
