using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.ServiceConfiguration
{
    public static class ServiceCollectionExtensions
    {
        public static class ServiceCollectionExtensions
        {
            public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<LibraryContext>(o => o.UseSqlite(configuration.GetConnectionString("LibraryConnection")));
                return services;
            }
        }
    }
}
