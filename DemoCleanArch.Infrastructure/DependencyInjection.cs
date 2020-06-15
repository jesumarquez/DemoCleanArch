using DemoCleanArch.Domain.Interfaces;
using DemoCleanArch.Infrastructure.Data;
using DemoCleanArch.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArch.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TodoDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Todo"));
            });
            services.AddTransient<ITodoRepository, TodoSqlRepository>();
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<TodoDbContext>();

            //services.AddIdentityServer()
            //    .AddApiAuthorization<IdentityUser, TodoDbContext>();

            return services;
        }
    }
}
