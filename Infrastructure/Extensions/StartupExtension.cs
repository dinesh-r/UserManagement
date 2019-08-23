using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using UserManagement.Infrastructure.ViewModel;

namespace UserManagement.Infrastructure.Extensions
{
    public static class StartupExtension
    {
        public static void AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.Configure<DatabaseSetting>(options => configuration.GetSection("DatabaseSetting").Bind(options));
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "User Management - API Documentation Version 1",
                    Description = "API documentation page lists all the REST API URL Contracts exposed by the Application."
                });
            });
        }

        public static void UseInfrastructureService(this IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, IList<Exception> exceptions)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            if (!exceptions.Any())
            {

                app.UseHttpsRedirection();
                app.UseRouting();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });

                app.UseStaticFiles();

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "User Management API V1");
                    c.RoutePrefix = "api/help";
                });
            }

            if (exceptions.Any())
            {
                app.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    await context.Response.WriteAsync("Error occurred while starting business Service. Please contact administrator for more details.").ConfigureAwait(false);
                });
            }
        }
    }
}
