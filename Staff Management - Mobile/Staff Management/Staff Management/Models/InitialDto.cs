using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Domain.DTO
{
    public class InitialDto
    {
        public List<StaffDto>? managers { get; set; }
        public List<TitleDto>? titles { get; set; }
        public List<StatusDto>? statuses { get; set; }
        public List<StaffTypeDto>? staffTypes { get; set; }
    }
}
