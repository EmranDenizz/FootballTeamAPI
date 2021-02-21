using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballTeam.BusinessLayer.Abstract;
using FootballTeam.BusinessLayer.Concrete;
using FootballTeam.DAL.Abstract;
using FootballTeam.DAL.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FootballTeam.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(); // Controller kulanca��m�z� bildirdik
            //E�er senin constructor'�n i�inde biri IFootballTeamRepository'ye ihtiya� duyarsa sen onun i�in bir FootballTeamRepository ��esi �ret.
            services.AddSingleton<IFootballTeamRepository, FootballTeamRepository>();
            services.AddSingleton<IFootballTeamService, FootballTeamManager>();
            services.AddSwaggerDocument(); //Swagger entegrasyonu ad�m1
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();//Swagger entegrasyonu ad�m2
            app.UseSwaggerUi3();//Swagger enteghrasyonu ad�m3

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Gelecek iste�i controller taraf�na y�nlendirdik
            });
        }
    }
}
