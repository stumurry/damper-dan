using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

using DamperDB;

using Microsoft.EntityFrameworkCore;

namespace damper_dan_client_server {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddDbContextPool<DamperContext>( // replace "YourDbContext" with the class name of your DbContext
                options => options.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=", // replace with your Connection String
                    mysqlOptions =>
                    {
                        mysqlOptions.ServerVersion(new Version(5, 7, 17), ServerType.MySql); // replace with your Server Version and Type
                    }
            ));

            services.AddCors (options => {
                options.AddPolicy ("AllowSpecificOrigin",
                    // Allow Angular App to speak with it.
                    builder => builder.WithOrigins ("http://localhost:4200"));
            });

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseHsts ();
            }

            // app.UseHttpsRedirection ();
            app.UseMvc ();
            app.UseCors("AllowSpecificOrigin");

        }
    }
}