using GEMBA.Domain;
using SM.Domain.DTO;
using SM.Infrastructure.Persistance.Models;
using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Services.Interfaces
{
    public interface IStaffService
    {
        public  List<StaffDto> GetStaff();
        public StaffDto GetStaffByid(int id);
        public List<StaffDto> GetStaffToExport();
        public List<Title> GetTitle();
        public List<StaffType> GetStaffType();
        public List<Status> GetStaffStatues();
        public List<Staff> GetStaffManagers();
        public bool SaveStaff(StaffDto staffModel);
        public bool UpdateStaff(StaffDto staffModel);
        public InitialDto GetInitialData();


    }
}
