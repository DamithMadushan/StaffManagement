using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Http;
using Microsoft.AspNetCore.Http;
using SM.Infrastructure.Persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace SM.Application
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        try
        {
                services.AddHttpContextAccessor();

                //services.AddDbContext<StaffManagementDBContext>((options) =>
                //{
                //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(StaffManagementDBContext).Assembly.FullName));

                //});

                services.AddDbContext<StaffManagementDBContext>((provider, options) => {
                    IConfiguration config = provider.GetRequiredService<IConfiguration>();
                    string connectionString = config.GetConnectionString("DefaultConnection")!;
                    options.UseSqlServer(connectionString);
                });


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
