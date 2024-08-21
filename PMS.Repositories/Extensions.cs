using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMS.Repositories.Context;
using System.Reflection;

namespace PMS.Repositories;

//public static class Extensions
//{
//    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
//    {
//        var executingAssembly = Assembly.GetExecutingAssembly();
//        services.AddAutoMapper(executingAssembly);

//        //services.AddScoped<IProjectRepository, ProjectRepository>();

//        /// <summary>
//        /// Dodanie kontekstu połączenia z bazą danych do domyślnego kontetenera IoC
//        /// </summary>
//        services.AddDbContext<PMSDbContext>(ctx => ctx.UseSqlServer(configuration.GetConnectionString("PMSCS")));

//        return services;
//    }
//}
