using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineBanking.Data;
using OnlineBanking.Models;

namespace OnlineBanking
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var conn = Configuration.GetConnectionString("DefaultConnection");//"Data Source=LAPTOP-DB6PV3D8;Initial Catalog=BankAppData;Integrated Security=True;";
            services.AddDbContext<BankAppDataContext>(options => options.UseSqlServer(conn));

            ////Sätter upp identity tjänsten
            services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<BankAppDataContext>()
            .AddDefaultTokenProviders();

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            services.AddSession();
            services.AddDistributedMemoryCache();

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

           
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseSession();
            app.UseDeveloperExceptionPage();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Customer}/{action=Statistics}/{id?}");
            });
        }
    }
}


