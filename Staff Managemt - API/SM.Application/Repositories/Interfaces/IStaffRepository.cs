using SM.Infrastructure.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Repositories.Interfaces
{
    public interface IStaffRepository
    {
        public List<Staff> GetStaff();
        public Staff GetStaffMember(int id);

        public List<Staff> GetStaffGrouped();

        public List<Title> GetTitle();

        public List<StaffType> GetStaffType();

        public List<Status> GetStaffStatus();

        public List<Staff> GetStaffManagers();

        public bool SaveStaffRecord(Staff staff);

        public bool UpdateStaffRecord(Staff staff);

    }
}
