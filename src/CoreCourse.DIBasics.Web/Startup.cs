using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCourse.DIBasics.Domain.CoffeeSystem;
using CoreCourse.DIBasics.Web.CoffeeWeb;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CoreCourse.DIBasics.Web
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
            services.AddSingleton(services);

            int coffeeSettings = Configuration.GetSection("CoffeeSettings").Get<int>();
            switch (coffeeSettings)
            {
                case 1: //1 == The app needs coffee with cream and sugar
                    services.AddTransient<ICreamer, Cream>();
                    services.AddTransient<ISweetener, Sugar>();
                    break;
                case 2: //2 == The app needs coffee with milk and honey
                    services.AddTransient<ICreamer, Milk>();
                    services.AddTransient<ISweetener, Honey>();
                    break;
                case 3: //3 == The app needs coffee with liquor
                    services.AddTransient<ICreamer, Whiskey>();
                    services.AddTransient<ISweetener, Sugar>();
                    break;
                case 4: //3 == The app needs "Random" implementations of creamers and sweeteners
                    services.AddTransient<ICreamer, RandomCreamer>();
                    services.AddTransient<ISweetener, RandomSweetener>();
                    break;
            }

            services.AddTransient<ICoffeeCup, CoffeeCup>();
            var random = new Random();
            services.AddSingleton<Random>(random);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
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
