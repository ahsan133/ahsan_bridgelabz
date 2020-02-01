// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace Fundoo
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Threading.Tasks;
    using FundooManager.Interface;
    using FundooManager.Manager;
    using FundooRepository.Context;
    using FundooRepository.Interfaces;
    using FundooRepository.Repository;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Startup class.
    /// </summary>
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
       
        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        //// This method gets called by the runtime. Use this method to add services to the container.
        //// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940        
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContextPool<UserContext>(
             options => options.UseSqlServer(Configuration.GetConnectionString("UserDbConnection")));

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserManager, UserManager> ();

            services.AddTransient<INotesRepository, NotesRepository>();
            services.AddTransient<INotesManager, NotesManager>();

            services.AddTransient<ILabelRepository, LabelRepository>();
            services.AddTransient<ILabelManager, LabelManager>();

     

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info
            //    {
            //        Version = "v1",
            //        Title = "Fundoo API",
            //        Description = "ASP.NET Core Web API"
            //    });
            //});
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The env.</param>
        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
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

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
