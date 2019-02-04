using System;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Interfaces;
using TodoApp.Repository;

namespace TodoApp.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigurePostgreSQLContext(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config["PostgreSQLConnection:connectionString"];
            services.AddDbContext<RepositoryContext>(options => options.UseNpgsql(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
