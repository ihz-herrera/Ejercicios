using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MyApp.Consultorio.API.Extenciones;
using MyApp.Consultorio.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Consultorio.API
{
    public class Startup
    {
        //Constructor
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //********************************/
            //***** Lineas personalizadas ****/
            //********************************/
            #region Custom lines

            services.ConfigureCors();
            services.ConfigureIISIntegration();

            string SqlConnection = Configuration.GetConnectionString("SqlConnectionStr") ;

            services.ConfigureSQLDbContext(SqlConnection);

            #endregion
            //*** FIN Lineas personalizadas ***/


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyApp.Consultorio.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(
                    c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyApp.Consultorio.API v1"));
            }

            app.UseHttpsRedirection();
            

            app.UseRouting();

            // Lineas personalizada
            #region Custom lines
            app.UseCors("CorsPolicy"); // Configuracion de Cors
            #endregion
           
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
