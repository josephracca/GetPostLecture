using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureWithAngel.service;
using LectureWithAngel.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LectureWithAngel
{
    //class
    public class Startup
    {
        //functions
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        //FOCUS HEREservices folder is our data access alyer, runs what logic we need it to do, get info, and returns info to our controller, this is how we will be using our services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<UserInfoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. //will show us how to get info from the controller???
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();
            // disable so that the routes will work correctly
            // live serve does not have a certificate for SSL, so https will not work, will talk about gow to migrate to SSL

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
