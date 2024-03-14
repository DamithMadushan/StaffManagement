using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddCommonServices(this IServiceCollection services, IConfiguration configuration)
    {
        try
        {

            #region Repositories
        
            #endregion

            #region Services
           
            #endregion

            return services;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
}
