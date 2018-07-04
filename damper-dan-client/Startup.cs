using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DamperDB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace damper_dan_client {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();

            // Still not working correctly;  Switching to regular DBContext()

            services.AddDbContextPool<DamperContext> ( // replace "YourDbContext" with the class name of your DbContext
                options => options.UseMySql ("Server=localhost;Database=tstrat_damper;User=root;Password=;", // replace with your Connection String
                    mysqlOptions => {
                        mysqlOptions.ServerVersion (new Version (5, 7, 17), ServerType.MySql); // replace with your Server Version and Type
                    }
                ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                app.UseWebpackDevMiddleware (new WebpackDevMiddlewareOptions {
                    HotModuleReplacement = true
                });
            } else {
                app.UseExceptionHandler ("/Home/Error");
            }

            app.UseStaticFiles ();

            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute (
                    name: "spa-fallback",
                    defaults : new { controller = "Home", action = "Index" });
            });

        }
    }
}