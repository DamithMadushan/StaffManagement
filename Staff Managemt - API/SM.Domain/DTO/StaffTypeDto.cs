using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Model.Models
{

    public class StaffTypeDto
    {
        public int Id { get; set; }

        public string? Type { get; set; }

        public List<StaffDto>? Staff { get; set; }
    }
}
