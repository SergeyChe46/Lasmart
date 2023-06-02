using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Lasmart.Repository;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.Services
{
    public static class RegisterServices
    {
        /// <summary>
        /// Регистрация баз данных.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterDatabase(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();
        }
        public static void RegisterRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<RepositoryManager>();
        }
    }
}