using System;
using System.Collections.Generic;

namespace SM.DBAccess.DBModel;

public partial class Staff
{
    public int Id { get; set; }

    public int StaffTypeId { get; set; }

    public int TitleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleInitial { get; set; }

    public string? HomePhone { get; set; }

    public string CellPhone { get; set; } = null!;

    public string? OfficeExtention { get; set; }

    public string? Irdnumber { get; set; }

    public int StatusId { get; set; }

    public int? ManagerId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Staff> InverseManager { get; set; } = new List<Staff>();

    public virtual Staff? Manager { get; set; }

    public virtual StaffType StaffType { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual Title Title { get; set; } = null!;
}
