using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
namespace HelpDesk
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
            services.AddMvc();

            services.AddDistributedMemoryCache();
            ////////////// Call AddSession And Set Timeout to 30 minutes //////
            services.AddSession(opt => opt.IdleTimeout = TimeSpan.FromMinutes(30));


			///// Add Connection 11-12-2017 /////
			//var connection = @"Data Source=andon_server;Initial Catalog=HelpDesk;User ID=sa;Password=p@$$w0rd";
			//services.AddDbContext<HelpDeskContext>(op => op.UseSqlServer(connection));


			//// This Connection for GetConnectionString in appserrings.json /////
			services.AddDbContext<HelpDeskContext>(op => op.UseSqlServer(Configuration.GetConnectionString("ANDON_SERVER")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //////////////
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();

           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=UserHelpDesk}/{action=MainNews}/{id?}");
                //template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
