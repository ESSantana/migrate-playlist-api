using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PlaylistApi.AutoMapper;
using PlaylistApi.Repository;
using PlaylistApi.Services;

namespace PlaylistApi
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
            services.AddControllers();
            
            services.AddAutoMapper( new Assembly[] {typeof(AutoMapperProfiles).GetTypeInfo().Assembly});

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo{
                    Description = "Api to migrate playlist between Spotify and Deezer",
                    Title = "Migrate playlists API",
                    Version = "V0.1"
                });
            });

            #region DependencyInjection
            services.AddScoped<IDeezerService, DeezerService>();
            services.AddScoped<IDeezerRepository, DeezerRepository>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI( s => {
                s.SwaggerEndpoint("/swagger/v1/swagger.json","My API V0.1");
            });
        }
    }
}
