using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Model.Models
{
    public class StaffModel
    {
        public int Id { get; set; }

        public int StaffTypeId { get; set; }

        public int TitleId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MiddleInitial { get; set; }

        public string? HomePhone { get; set; }

        public string? CellPhone { get; set; }

        public string? OfficeExtention { get; set; }

        public string? Irdnumber { get; set; }

        public int StatusId { get; set; }

        public int? ManagerId { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }
        public string? Status { get; set; }
        public string? Title { get; set; }
        public string? StaffType { get; set; }
        public string? Manager { get; set; }

        public List<StaffModel>? InverseManager { get; set; }

        public StaffModel? Manager1 { get; set; }

        public StaffTypeModel? StaffType1 { get; set; }

        public StatusModel? Status1 { get; set; }

        public TitleModel? Title1 { get; set; }
    }

}
