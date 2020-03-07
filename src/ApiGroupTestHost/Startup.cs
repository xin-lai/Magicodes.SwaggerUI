using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magicodes.SwaggerUI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ApiGroupTestHost
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //添加自定义API文档生成(支持文档配置)
            services.AddMagicodesSwaggerGen(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => routes.MapRoute(
                "default",
                "{controller=Home}/{action=Index}/{id?}"));

            //启用自定义API文档(支持文档配置)
            app.UseMagicodesSwaggerUI(Configuration);
        }
    }
}
