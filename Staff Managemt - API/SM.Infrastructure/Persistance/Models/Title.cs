using System;
using System.Collections.Generic;

namespace SM.Infrastructure.Persistance.Models;

public partial class Title
{
    public int Id { get; set; }

    public string Title1 { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();
}
