using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspEFCore.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AspEFCore.Web.Data;

namespace AspEFCore.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(
                options =>
               {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<MyContext>(
                options =>
                {
                    //解除数据库语句加密
                    options.EnableSensitiveDataLogging(true);
                    //用于数据库的
                    //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                },ServiceLifetime.Transient);

            services.AddDbContext<DataContext>(
                options =>
                {
                    //解除数据库语句加密
                    options.EnableSensitiveDataLogging(true);
                    //用于数据库的
                    //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                }, ServiceLifetime.Transient);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
