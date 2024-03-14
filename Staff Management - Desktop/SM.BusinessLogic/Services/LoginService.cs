using SM.DBAccess;
using SM.Model;
using SM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct.Resources;
using XSystem.Security.Cryptography;

namespace SM.BusinessLogic.Services
{
    public static class LoginService
    {

        public static bool LoginEmployee(LoginModel loginModel)
        {
            try
            {
                int staffCount = 0;

                //Hash the password
                loginModel.Password = Hash(loginModel.Password!);

                staffCount = LoginDBAccess.GetLoginUser(loginModel);

                if(staffCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static string Hash(string passwordToHash)
        {
            try
            {
                using (SHA1 sha1Hash = SHA1.Create())
                {
                    //From String to byte array
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(passwordToHash);
                    byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                    return hash;
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
