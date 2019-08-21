using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace webvitinh
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
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddMvc();
            services.AddMvc(options =>
            {
                options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            });
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();

            services.AddDbContext<OnlineShop1Context>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("Server=tcp:webvitinh.database.windows.net,1433;Initial Catalog=OnlineShop;Persist Security Info=False;User ID=hao;Password=Ronaldo142;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")));

            services.AddIdentity<IdentityUser, IdentityRole>()
             .AddEntityFrameworkStores<OnlineShop1Context>()
             .AddDefaultTokenProviders();

            services
                .AddAuthentication(o =>
                {
                    o.DefaultScheme = "Application";
                    o.DefaultSignInScheme = "External";
                })
                .AddCookie("Application")
                .AddCookie("External")
                .AddGoogle(googleOptions =>
                {
                    googleOptions.ClientId = "648235618237-o04oh6k8mgpokohsbbdn4664bp56ng8j.apps.googleusercontent.com";
                    googleOptions.ClientSecret = "PWTGoQuRlSyVyBO2qNJ5ZnrI";
                });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);//You can set Time   
            });

            //services.AddScoped<IService>(provider =>
            //{
            //    var dependency = provider.GetRequiredService<IDependency>();

            //    // You can select the constructor you want here.
            //    return new Service(dependency, "my string parameter");
            //});


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAuthentication(option => 
            {
                option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddFacebook(option =>
                {
                    option.AppId = "639247849806324";
                    option.AppSecret = "3c97056efc59e2f69e2a97fa6074b16e";
                })
                .AddCookie(options =>
                {
                    options.Cookie.Name = "Facebook";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();         
            app.UseDefaultFiles();
            app.UseCookiePolicy();

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationScheme = "ApplicationCookie";
            //});


            app.UseMvc(routes =>
            {
               
                //routes.MapRoute(
                //   name: "Area",
                //   template: "{area=Admin}/{controller=Login}/{action=Index}/{id?}");
               
                routes.MapRoute(
                   name: "ProductDetail",
                   template: "{controller=Product}/{action=chi-tiet}/{id?}");

                routes.MapRoute(
                  name: "Register",
                  template: "{controller=User}/{action=dang-ky}/{id?}");

                routes.MapRoute(
                  name: "Contact",
                  template: "{controller=Contact}/{action=lien-he}/{id?}");

                routes.MapRoute(
                  name: "Cart",
                  template: "{controller=Cart}/{action=gio-hang}/{id?}");

                routes.MapRoute(
                  name: "Add Cart",
                  template: "{controller=Cart}/{action=them-gio-hang}/{id?}");
                
                routes.MapRoute(
                  name: "Payment",
                  template: "{controller=Cart}/{action=thanh-toan}/{id?}");

                routes.MapRoute(
                  name: "Payment_2",
                  template: "{controller=Cart}/{action=Payment}/{id?}");

                routes.MapRoute(
                  name: "Payment Paypal",
                  template: "{controller=Cart}/{action=thanh-toan-paypal}/{id?}");

                routes.MapRoute(
                  name: "Payment GetPaypal",
                  template: "{controller=Cart}/{action=get-paypal}/{id?}");

                routes.MapRoute(
                  name: "Success",
                  template: "{controller=Cart}/{action=hoan-thanh}/{id?}");

                routes.MapRoute(
                  name: "Content",
                  template: "{controller=Content}/{action=tin-tuc}/{id?}");

                routes.MapRoute(
                  name: "Content Detail",
                  template: "{controller=Content}/{action=tin-tuc}/{id?}");

                routes.MapRoute(
                 name: "Content Tag",
                 template: "{controller=Content}/{action=tag}/{id?}");

                routes.MapRoute(
                  name: "Search",
                  template: "{controller=Product}/{action=Search}/{id?}");

                //routes.MapRoute(
                //  name: "Product Index",
                //  template: "{controller=Product}/{action=Index}/{id?}");

                //routes.MapRoute(
                //  name: "default",
                //  template: "{controller=Home}/{action=Index}/{id?}");
            });

            //CreateRoles(serviceProvider).Wait();
        }
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles   
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "ADMIN", "MEMBER", "MODERATOR" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1  
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            IdentityUser user = await UserManager.FindByIdAsync("10015");

            if (user == null)
            {
                user = new IdentityUser()
                {
                    UserName = "jignesh@gmail.com",
                    Email = "jignesh@gmail.com",
                };
                await UserManager.CreateAsync(user, "Test@123");
            }
            await UserManager.AddToRoleAsync(user, "ADMIN");


            IdentityUser user1 = await UserManager.FindByIdAsync("10005");

            if (user1 == null)
            {
                user1 = new IdentityUser()
                {
                    UserName = "tejas@gmail.com",
                    Email = "tejas@gmail.com",
                };
                await UserManager.CreateAsync(user1, "Test@123");
            }
            await UserManager.AddToRoleAsync(user1, "MEMBER");

            IdentityUser user2 = await UserManager.FindByIdAsync("10006");

            if (user2 == null)
            {
                user2 = new IdentityUser()
                {
                    UserName = "rakesh@gmail.com",
                    Email = "rakesh@gmail.com",
                };
                await UserManager.CreateAsync(user2, "Test@123");
            }
            await UserManager.AddToRoleAsync(user2, "MEMBER");

        }
    }
}
