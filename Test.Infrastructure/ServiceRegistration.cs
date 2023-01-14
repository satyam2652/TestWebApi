using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test.Application.Helpers;
using Test.Application.Interfaces;
using Test.Infrastructure.Repository;
using Test.Infrastructure.Service;

namespace Test.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IDepartmentsService, DepartmentService>();
            services.AddTransient<IDepartmentsRepo, DepartmentsRepo>();

            services.AddScoped<Common>();

        }
    }
}
