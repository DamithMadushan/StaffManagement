using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SM.Application.Repositories;
using SM.Application.Repositories.Interfaces;
using SM.Application.Services;
using SM.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        try
        {
            services.AddHttpContextAccessor();

            #region Repositories
            services.AddScoped<IStaffRepository, StaffRepository>();

            #endregion

            #region Services
            services.AddScoped<IStaffService, StaffService>();

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
