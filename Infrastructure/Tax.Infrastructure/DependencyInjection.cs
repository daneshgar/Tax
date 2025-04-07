using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tax.Infrastructure.Data;

namespace Tax.Infrastructure
{

        public static class DependencyInjection
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        sqlOptions => sqlOptions.EnableRetryOnFailure()));
                return services;
            }
        }

}
