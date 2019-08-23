using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using UserManagement.Infrastructure.Extensions;
using UserManagement.Service.Security.V1.Managers;
using UserManagement.Service.Security.V1.Managers.Contracts;
using UserManagement.Service.Security.V1.Repositories;
using UserManagement.Service.Security.V1.Repositories.Contracts;

namespace UserManagement.Service.Security
{
    public class Startup
    {
        private List<Exception> _exceptions;

        public Startup(IConfiguration configuration)
        {
            _exceptions = new List<Exception>();
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddInfrastructureService(Configuration);

                services.AddDbContext<SecurityDbContext>();

                services.AddScoped<ICommonManager, CommonManager>();
                services.AddScoped<IRolesManager, RolesManager>();

                services.AddScoped<ICommonRepository, CommonRepository>();
                services.AddScoped<IRolesRepository, RolesRepository>();
            }
            catch (Exception ex)
            {
                _exceptions.Add(ex);
            }
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseInfrastructureService(env, Configuration, _exceptions);
        }
    }
}
