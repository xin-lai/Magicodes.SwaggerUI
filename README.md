# Magicodes.SwaggerUI
快速配置和集成SwaggerUI
Magicodes SwaggerUI扩展库

配置Demo：
```
  "SwaggerDoc": {
    "IsEnabled": "true",
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
    //设置api首页从嵌入资源中加载
    "ManifestResourceAssembly": "Magicodes.Admin.Web.Host",
    "ManifestResourceUrl": "Magicodes.Admin.Web.wwwroot.swagger.ui.index.html"
  },
```
