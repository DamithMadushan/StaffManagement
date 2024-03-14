using SM.Infrastructure.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.Repositories
{
    public class BaseRepository
    {
        protected readonly StaffManagementDBContext _db;
        public BaseRepository(StaffManagementDBContext db)
        {
            _db = db;
        }

    }
}
