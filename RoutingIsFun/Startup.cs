using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingIsFun
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            //< p >< a href = "/en-us/pdp?id=c7f51233-a913-43b3-bc7c-59b30e25e04b" >/ en - us / pdp ? id = c7f51233 - a913 - 43b3 - bc7c - 59b30e25e04b </ a ></ p >

            //< p >< a href = "/2021/06/15/uberall-raises-115m-acquires-momentfeed-to-scale-up-its-location-marketing-services/" >/ 2021 / 06 / 15 / uberall - raises - 115m - acquires - momentfeed - to - scale - up - its - location - marketing - services /</ a ></ p >

            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                    name: "pdp",
                    pattern: "{language}/pdp",
                    new { routeName = "pdp", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "environmentHub",
                    pattern: "environments/environment/{id}/hub",
                    new { routeName = "environmentHub", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "manage",
                    pattern: "manage/{thingToManage}/{thingGuid}/{subThing}/{subThingId}/details",
                    new { routeName = "manage", controller = "Manage", action = "Details" }
                );

                endpoints.MapControllerRoute(
                    name: "main",
                    pattern: "main",
                    new { routeName = "main", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "powerapps",
                    pattern: "{language}/powerapps/maker/data-platform",
                    new { routeName = "powerapps", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "showVideo",
                    pattern: "shows/{showName}/video/{showId}/{slug}",
                    new { routeName = "showVideo", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "episodeGuide",
                    pattern: "shows/{showName}/episode-guide/{season}/{title}",
                    new { routeName = "episodeGuide", controller = "Home", action = "CatchAll" }
                );

                endpoints.MapControllerRoute(
                    name: "dateFirstPostTitleOnly",
                    pattern: "{year}/{month}/{day}/{title}",
                    new { routeName = "dateFirstPostTitleOnly", controller = "Home", action = "DateFirstPostTitleOnly" }
                );

                endpoints.MapControllerRoute(
                    name: "dateFirstPost",
                    pattern: "{year}/{month}/{day}/{category}/{title}",
                    new { routeName = "dateFirstPost", controller = "Home", action = "DateFirstPost" }
                );

                endpoints.MapControllerRoute(
                    name: "dp",
                    pattern: "{productName}/dp/{id}",
                    new { routeName = "dp", controller = "Dp", action = "Index" }
                );

                endpoints.MapControllerRoute(
                    name: "watch",
                    pattern: "watch",
                    new { routeName = "watch", controller = "Home", action = "Watch" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}",
                    new { routeName = "default" });
            });
        }
    }
}

