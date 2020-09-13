using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARDC.Admin.API.Services;
using ARDC.Admin.Data.Model;
using ARDC.Admin.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ARDC.Admin.API
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
            services.AddDbContext<ARDCDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("conn")));

            services.AddScoped<IOfficialsRepository, OfficialsRepository>();
            services.AddScoped<IOfficialsService, OfficialsService>();

            services.AddControllers();

            services.AddCors(cx =>
            {
                cx.AddPolicy("AllowedDomains",
                    builder =>
                    {
                        builder.WithOrigins(Configuration["Cors:AllowedDomains"].Split(";"))
                        .WithMethods("OPTIONS", "GET", "POST", "PUT", "DELETE")
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowedDomains");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
