# Magicodes.SwaggerUI
快速配置和集成SwaggerUI
Magicodes SwaggerUI扩展库

配置Demo：
```
  "SwaggerDoc": {
    "IsEnabled": "true",
	//Swagger 名称，1.7.8版本（包含1.7.8）以后都需要添加此配置
	"Name":"Magicodes"
    "Title": "Api Documents",
    "Version": "v1",
    "Description": "",
    "Contact": {
      "Name": "心莱科技",
      "Email": "xinlai@xin-lai.com"
    },
    //以便于在界面上显示验证（Authorize）按钮，验证按钮处理逻辑基于 wwwroot/swagger/ui/index.html
    "Authorize": "true",
    "HiddenApi": {
      "IsEnabled": "false",
      "HiddenUrls": ""
    },
    //将枚举值以字符串显示
    "DescribeAllEnumsAsStrings": true,
    //设置api首页从嵌入资源中加载
    "ManifestResourceAssembly": "Magicodes.Admin.Web.Host",
    "ManifestResourceUrl": "Magicodes.Admin.Web.wwwroot.swagger.ui.index.html"
  },
```

注入代码：

//添加自定义API文档生成(支持文档配置)
public IServiceProvider ConfigureServices(IServiceCollection services)
{
services.AddCustomSwaggerGen(_appConfiguration, _hostingEnvironment);
}

public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
//启用自定义API文档(支持文档配置)
app.UseCustomSwaggerUI(_appConfiguration);
}