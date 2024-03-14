using System;
using System.Collections.Generic;

namespace SM.DBAccess.DBModel;

public partial class StaffType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
