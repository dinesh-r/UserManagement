using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using UserManagement.Infrastructure.Constants;
using UserManagement.Infrastructure.ViewModel;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
            });

            var settingsSection = Configuration.GetSection("ServiceSetting");
            var serviceSetting = settingsSection.Get<ServiceSetting>();

            IHttpClientBuilder httpClientBuilder = null;
            if (serviceSetting != null)
            {
                httpClientBuilder = services.AddHttpClient(serviceSetting.ServiceName, client =>
                {
                    client.BaseAddress = new Uri(serviceSetting.ServiceUrl);
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                });
            }

            //services.AddAntiforgery(options => options.HeaderName = ANTIFORGERY_TOKEN_HEADER_NAME);
            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");

            //services.AddLocalization();
            services.AddControllersWithViews(options =>
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())).AddViewLocalization()
                .AddNewtonsoftJson(options =>
                       options.SerializerSettings.ContractResolver =
                          new CamelCasePropertyNamesContractResolver());
            services.AddRazorPages();            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "Security",
                  areaName: "Security",
                  pattern: "Security/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
