using SM.DBAccess.DBModel;
using SM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace SM.DBAccess
{
    public static class LoginDBAccess
    {

        public static int GetLoginUser(LoginModel loginModel)
        {
            try
            {
                int staffCount = 0;

                using (StaffManagementContext db = new StaffManagementContext())
                {
                    staffCount =  db.Staff.Where(x => x.Username == loginModel.UserName && x.Password == loginModel.Password!).Select(x => x.Id).Count();
                }

                return staffCount;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
