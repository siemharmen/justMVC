    using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReversiMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReversiMVC.Hubs;
using ReversiMVC.Models;
using Owin;
using Microsoft.Owin;
using ReversiMVC.Controllers;

[assembly: OwinStartup(typeof(ReversiMVC.Startup))]
namespace ReversiMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }   
        string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddHttpClient<SpelsController>();

            services.AddHttpClient("Api", options =>
            {
                //https://localhost:5001/
                //options.BaseAddress = new System.Uri("https://localhost:44339/api/");
                options.BaseAddress = new System.Uri("https://localhost:5001/api/");
            });
            services.AddSignalR();


            services.AddAuthorization(options =>
            {
                options.AddPolicy("BeheerderOnly ", policy => policy.RequireClaim("Beheerder"));
                options.AddPolicy("MediatorOnly", policy => policy.RequireClaim("Mediator"));
                options.AddPolicy("Beheerder", policy => policy.RequireClaim("Beheerder"));
                options.AddPolicy("Mediator", policy =>
                     policy.RequireAssertion(context =>
                     context.User.HasClaim(c =>
                     (c.Type == "Mediator" || c.Type == "Beheerder"))));
            });
            services.AddCors(options =>
            {
              options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:63342").AllowAnyHeader().AllowAnyMethod();
                          policy.WithOrigins("http://localhost:5001").AllowAnyHeader().AllowAnyMethod();

                      });}
            );

                services.AddHttpClient<ReCaptcha>(x =>
            {
                x.BaseAddress = new Uri("https://www.google.com/recaptcha/api/siteverify");
            });

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeAreaPage("Identity", "/Admin/Users", "Beheerder");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.MapSignalR();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapDefaultControllerRoute().RequireAuthorization();
                //endpoints.MapHub<ChatHub>("/notify");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");  
                    endpoints.MapRazorPages();
            });
        }
    }
}
