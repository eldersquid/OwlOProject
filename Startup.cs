using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthSystem.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using owlo_plan.Models;
using owlo_plan.Services;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA
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
            services.AddRazorPages();
            services.AddTransient<OwleeService>();
            services.AddDbContext<OwloDBContext>();
            services.AddTransient<VoucherService>();
            services.AddTransient<LuckyDrawService>();
            services.AddTransient<FAQService>();
            services.AddTransient<VoucherDistributionService>();
            services.AddTransient<Controllers.IntentController>();
            services.AddTransient<Controllers.AdministrationController>();
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            //nuzul
            services.AddDbContext<OwloPlanDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConn")));
            services.AddRazorPages();
            services.AddTransient<ProjectService>();
            services.AddTransient<ResourceService>();
            services.AddTransient<MeetingService>();


            //Jing kai
            services.AddTransient<WorkshopService>();
            services.AddTransient<VenueService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
