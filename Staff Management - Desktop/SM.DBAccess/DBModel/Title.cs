using System;
using System.Collections.Generic;

namespace SM.DBAccess.DBModel;

public partial class Title
{
    public int Id { get; set; }

    public string Title1 { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
