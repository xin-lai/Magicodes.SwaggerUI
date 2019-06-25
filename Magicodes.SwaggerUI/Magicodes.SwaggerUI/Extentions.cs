using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.SwaggerUI
{
    public static class Extentions
    {
        /// <summary>
        /// 添加自定义API文档生成(支持文档配置)
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="hostingEnvironment"></param>
        public static void AddCustomSwaggerGen(this IServiceCollection services, IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            if (configuration?["SwaggerDoc:IsEnabled"] == null)
            {
                return;
            }
            if (bool.Parse(configuration["SwaggerDoc:IsEnabled"]))
            {
                var webRootDirectory = hostingEnvironment.WebRootPath ?? Directory.GetCurrentDirectory();
                //设置API文档生成
                services.AddSwaggerGen(options =>
                {
                    //将所有枚举显示为字符串
                    if (bool.Parse(configuration["SwaggerDoc:DescribeAllEnumsAsStrings"]))
                        options.DescribeAllEnumsAsStrings();

                    options.SwaggerDoc(configuration["SwaggerDoc:Name"], new Info
                    {
                        Title = configuration["SwaggerDoc:Title"],
                        Version = configuration["SwaggerDoc:Version"],
                        Description = configuration["SwaggerDoc:Description"],
                        Contact = new Contact
                        {
                            Name = configuration["SwaggerDoc:Contact:Name"],
                            Email = configuration["SwaggerDoc:Contact:Email"]
                        }
                    });

                    if (bool.Parse(configuration["SwaggerDoc:Authorize"] ?? "false"))
                        //以便于在界面上显示验证（Authorize）按钮，验证按钮处理逻辑基于 wwwroot/swagger/ui/index.html
                        options.AddSecurityDefinition("Bearer", new BasicAuthScheme());

                    //遍历所有xml并加载
                    var paths = new List<string>();
                    if (!string.IsNullOrWhiteSpace(webRootDirectory) && Directory.Exists(webRootDirectory))
                    {
                        var plusPath = Path.Combine(webRootDirectory, "PlugIns");
                        if (Directory.Exists(plusPath))
                        {
                            var xmlFiles = new DirectoryInfo(plusPath).GetFiles("*.xml");
                            foreach (var item in xmlFiles)
                            {
                                paths.Add(item.FullName);
                            }
                        }
                    }
                    
                    var binXmlFiles = new DirectoryInfo(hostingEnvironment.ContentRootPath).GetFiles("*.xml", hostingEnvironment.EnvironmentName == "Development" ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    foreach (var item in binXmlFiles)
                    {
                        paths.Add(item.FullName);
                    }

                    foreach (var filePath in paths)
                    {
                        options.IncludeXmlComments(filePath);
                    }
                    options.DocInclusionPredicate((docName, description) => true);
                    options.DocumentFilter<HiddenApiFilter>(configuration);

                    if (configuration["SwaggerDoc:UseFullNameForSchemaId"] != null && bool.Parse(configuration["SwaggerDoc:UseFullNameForSchemaId"]))
                    {
                        //使用全名作为架构id
                        options.CustomSchemaIds(p => p.FullName);
                    }
                });
            }
        }

        /// <summary>
        /// 启用自定义API文档(支持文档配置)
        /// </summary>
        /// <param name="app"></param>
        /// <param name="configuration"></param>
        public static void UseCustomSwaggerUI(this IApplicationBuilder app, IConfiguration configuration)
        {
            if (configuration == null || configuration["SwaggerDoc:IsEnabled"] == null)
            {
                return;
            }
            if (bool.Parse(configuration["SwaggerDoc:IsEnabled"]))
            {
                app.UseSwagger(c => { c.RouteTemplate = "{documentName}/swagger.json"; });
                // 加载swagger-ui 资源 (HTML, JS, CSS etc.)
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint($"/{configuration["SwaggerDoc:Name"]}/swagger.json", configuration["SwaggerDoc:Title"] ?? "App API V1");
                    //允许通过嵌入式资源配置首页
                    if (!string.IsNullOrWhiteSpace(configuration["SwaggerDoc:ManifestResourceUrl"]))
                    {
                        options.IndexStream = () =>
                        Assembly.Load(configuration["SwaggerDoc:ManifestResourceAssembly"])
                   .GetManifestResourceStream(configuration["SwaggerDoc:ManifestResourceUrl"]);
                    }
                });
            }
        }
    }
}
