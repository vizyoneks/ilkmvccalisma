using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspnetCoreMiddleWares.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspnetCoreMiddleWares
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.Map("/admin", config => config.Use(async (context, next) =>
            {
                if (context.User.Identity.IsAuthenticated)
                {

                }
                await context.Response.WriteAsync("Yetkiniz yok");
            }));

            //eğer gelen istek post değilse ve url sepete-at ise anasayfaya gönderen bir middleware yazınız.

            app.Use(async (context, next) =>
            {
                if (true)
                {
                    //await next.Invoke();
                    await next();
                }
                else
                {
                    await context.Response.WriteAsync("Hello, World!");
                }
            });

            app.UseAuthControl();

            app.MapWhen(config => !config.Request.Method.Equals("POST") && config.Request.Path == "/sepete-at", appBuilder => appBuilder.Run(async context => {
                 context.Response.Redirect("/");
            }));

            //Short circuit
            //app.Run(async context =>
            //{
            //    if (!context.Request.IsHttps)
            //    {
            //        await context.Response.WriteAsync("Hello, World!");
            //    }
            //});

            //a,b,c
            //A
            //B
            //C
            //B
            //A

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();
            app.UseCookiePolicy();
        }
    }
}
