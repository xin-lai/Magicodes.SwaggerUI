# Magicodes.SwaggerUI
通过配置文件简单配置即可快速完成SwaggerUI的配置，包括：
- SwaggerUI的文档信息
- API分组
- API隐藏
- API JSON生成（枚举、API架构Id）
- 验证
- 自定义页面

支持.NET Core 2.2和3.1。版本日志和使用教程见下文。

## 特点
- 通过配置文件简单配置即可完成SwaggerUI的API格式JSON生成和集成
![](./res/3.png "图3")
- 支持API分组和隐藏
![](./res/1.png "图1")
![](./res/2.png "图1")
- 支持自定义页面和验证

## Nuget包

| 名称     |      Nuget      |
|----------|:-------------:|
| Magicodes.SwaggerUI  |  [![NuGet](https://buildstats.info/nuget/Magicodes.SwaggerUI)](https://www.nuget.org/packages/Magicodes.SwaggerUI) |

### Magicodes Nuget包推荐

## 相关Nuget包

| 名称     |      说明      |      Nuget      | GitHUb |
|----------|:-------------:|:-------------:|:-------------:|
| Magicodes.IE.Excel |Excel导入导出| [![NuGet](https://buildstats.info/nuget/Magicodes.IE.Excel)](https://www.nuget.org/packages/Magicodes.IE.Excel) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.IE.Core |导入导出核心库| [![NuGet](https://buildstats.info/nuget/Magicodes.IE.Core)](https://www.nuget.org/packages/Magicodes.IE.Core) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.IE.HTML | HTML导入导出|[![NuGet](https://buildstats.info/nuget/Magicodes.IE.HTML)](https://www.nuget.org/packages/Magicodes.IE.HTML) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.IE.Pdf |Pdf导出| [![NuGet](https://buildstats.info/nuget/Magicodes.IE.Pdf)](https://www.nuget.org/packages/Magicodes.IE.Pdf) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.IE.Word |Word导出| [![NuGet](https://buildstats.info/nuget/Magicodes.IE.Word)](https://www.nuget.org/packages/Magicodes.IE.Word) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.IE.Csv |Csv导入导出| [![NuGet](https://buildstats.info/nuget/Magicodes.IE.Csv)](https://www.nuget.org/packages/Magicodes.IE.Csv) |[dotnetcore](https://github.com/dotnetcore)/**[Magicodes.IE](https://github.com/dotnetcore/Magicodes.IE)**|
| Magicodes.WeChat.MiniProgram |小程序SDK |[![NuGet](https://buildstats.info/nuget/Magicodes.WeChat.MiniProgram)](https://www.nuget.org/packages/Magicodes.WeChat.MiniProgram) |**[Magicodes.WxMiniProgram.Sdk](https://github.com/xin-lai/Magicodes.WxMiniProgram.Sdk)**|
| Magicodes.Sms.Aliyun |阿里云短信 | [![NuGet](https://buildstats.info/nuget/Magicodes.Sms.Aliyun)](https://www.nuget.org/packages/Magicodes.Sms.Aliyun) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Sms](https://github.com/xin-lai/Magicodes.Sms)**|
| Magicodes.Sms.Core | 短信核心库 | [![NuGet](https://buildstats.info/nuget/Magicodes.Sms.Core)](https://www.nuget.org/packages/Magicodes.Sms.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Sms](https://github.com/xin-lai/Magicodes.Sms)**|
| Magicodes.Sms.Aliyun.Abp | 阿里云短信Abp模块 | [![NuGet](https://buildstats.info/nuget/Magicodes.Sms.Aliyun.Abp)](https://www.nuget.org/packages/Magicodes.Sms.Aliyun.Abp) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Sms](https://github.com/xin-lai/Magicodes.Sms)**|
| Magicodes.Storage.Core |通用存储核心库| [![NuGet](https://buildstats.info/nuget/Magicodes.Storage.Core)](https://www.nuget.org/packages/Magicodes.Storage.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Storage](https://github.com/xin-lai/Magicodes.Storage)**|
| Magicodes.Storage.AliyunOss.Core |阿里云OSS存储| [![NuGet](https://buildstats.info/nuget/Magicodes.Storage.AliyunOss.Core)](https://www.nuget.org/packages/Magicodes.Storage.AliyunOss.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Storage](https://github.com/xin-lai/Magicodes.Storage)**|
| Magicodes.Storage.Local.Core |本地存储| [![NuGet](https://buildstats.info/nuget/Magicodes.Storage.Local.Core)](https://www.nuget.org/packages/Magicodes.Storage.Local.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Storage](https://github.com/xin-lai/Magicodes.Storage)**|
| Magicodes.Storage.Tencent.Core |腾讯云存储| [![NuGet](https://buildstats.info/nuget/Magicodes.Storage.Tencent.Core)](https://www.nuget.org/packages/Magicodes.Storage.Tencent.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Storage](https://github.com/xin-lai/Magicodes.Storage)**|
| Magicodes.Storage.Abp.Core | 通用存储ABP模块集成| [![NuGet](https://buildstats.info/nuget/Magicodes.Storage.Abp.Core)](https://www.nuget.org/packages/Magicodes.Storage.Abp.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Storage](https://github.com/xin-lai/Magicodes.Storage)**|
| Magicodes.WeChat.SDK.Core |微信SDK | [![NuGet](https://buildstats.info/nuget/Magicodes.WeChat.SDK.Core)](https://www.nuget.org/packages/Magicodes.WeChat.SDK.Core) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.WeChat.SDK](https://github.com/xin-lai/Magicodes.WeChat.SDK)**|
| Magicodes.SwaggerUI |SwaggerUI API快速配置和分组| [![NuGet](https://buildstats.info/nuget/Magicodes.SwaggerUI)](https://www.nuget.org/packages/Magicodes.SwaggerUI) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.SwaggerUI](https://github.com/xin-lai/Magicodes.SwaggerUI)**|
| Magicodes.Pay.Alipay  |支付宝支付库|  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Alipay)](https://www.nuget.org/packages/Magicodes.Pay.Alipay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Notify  |支付通用回调库|   [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Notify)](https://www.nuget.org/packages/Magicodes.Pay.Notify) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Wxpay  |微信支付库|  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Wxpay)](https://www.nuget.org/packages/Magicodes.Pay.Wxpay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Alipay.Global |国际支付宝支付库 |  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Alipay.Global)](https://www.nuget.org/packages/Magicodes.Pay.Alipay.Global) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Allinpay  | 通联支付库 | [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Allinpay)](https://www.nuget.org/packages/Magicodes.Pay.Allinpay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Abp  | ABP 支付通用封装库| [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Abp)](https://www.nuget.org/packages/Magicodes.Pay.Abp) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Abp.Allinpay  |ABP 通联支付模块|  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Abp.Allinpay)](https://www.nuget.org/packages/Magicodes.Pay.Abp.Allinpay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Abp.Wxpay  | ABP 微信支付模块| [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Abp.Wxpay)](https://www.nuget.org/packages/Magicodes.Pay.Abp.Wxpay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Alipay.Global  | ABP 国际支付宝模块 |  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Alipay.Global)](https://www.nuget.org/packages/Magicodes.Pay.Alipay.Global) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Pay.Alipay  | ABP 支付宝模块 |  [![NuGet](https://buildstats.info/nuget/Magicodes.Pay.Alipay)](https://www.nuget.org/packages/Magicodes.Pay.Alipay) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.Pay](https://github.com/xin-lai/Magicodes.Pay)**|
| Magicodes.Abp.Castle.NLog  | ABP Nlog支持模块 |  [![NuGet](https://buildstats.info/nuget/Magicodes.Abp.Castle.NLog)](https://www.nuget.org/packages/Magicodes.Abp.Castle.NLog) |[xin-lai](https://github.com/xin-lai)/**[Abp.Castle.NLog](https://github.com/xin-lai/Abp.Castle.NLog)**|
| Magicodes.WxMiniProgram.Sdk  |微信小程序SDK|  [![NuGet](https://buildstats.info/nuget/Magicodes.WxMiniProgram.Sdk)](https://www.nuget.org/packages/Magicodes.WxMiniProgram.Sdk) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.WxMiniProgram.Sdk](https://github.com/xin-lai/Magicodes.WxMiniProgram.Sdk)**|
| Magicodes.WxMiniProgram.Sdk.Abp  |微信小程序SDK Abp模块|   [![NuGet](https://buildstats.info/nuget/Magicodes.WxMiniProgram.Sdk.Abp)](https://www.nuget.org/packages/Magicodes.WxMiniProgram.Sdk.Abp) |[xin-lai](https://github.com/xin-lai)/**[Magicodes.WxMiniProgram.Sdk](https://github.com/xin-lai/Magicodes.WxMiniProgram.Sdk)**|
| Magicodes.Dingtalk.SDK |钉钉SDK| [![NuGet](https://buildstats.info/nuget/Magicodes.Dingtalk.SDK)](https://www.nuget.org/packages/Magicodes.Dingtalk.SDK)  | [xin-lai](https://github.com/xin-lai)/**[Magicodes.Dingtalk.SDK](https://github.com/xin-lai/Magicodes.Dingtalk.SDK)**|
| Magicodes.DynamicSqlApi.Core  | 根据SQL自动解析生成动态API | [![NuGet](https://buildstats.info/nuget/Magicodes.DynamicSqlApi.Core)](https://www.nuget.org/packages/Magicodes.DynamicSqlApi.Core) | **[Magicodes.DynamicSqlApi](https://github.com/xin-lai/Magicodes.DynamicSqlApi)** |
| Magicodes.DynamicSqlApi.All |  根据SQL自动解析生成动态API |  [![NuGet](https://buildstats.info/nuget/Magicodes.DynamicSqlApi.All)](https://www.nuget.org/packages/Magicodes.DynamicSqlApi.All)   |  **[Magicodes.DynamicSqlApi](https://github.com/xin-lai/Magicodes.DynamicSqlApi)** |
| Magicodes.DynamicSqlApi.CsScript |根据SQL自动解析生成动态API |    [![NuGet](https://buildstats.info/nuget/Magicodes.DynamicSqlApi.CsScript)](https://www.nuget.org/packages/Magicodes.DynamicSqlApi.CsScript)   | **[Magicodes.DynamicSqlApi](https://github.com/xin-lai/Magicodes.DynamicSqlApi)** |
| Magicodes.DynamicSqlApi.Dapper | 根据SQL自动解析生成动态API |   [![NuGet](https://buildstats.info/nuget/Magicodes.DynamicSqlApi.Dapper)](https://www.nuget.org/packages/Magicodes.DynamicSqlApi.Dapper)   | **[Magicodes.DynamicSqlApi](https://github.com/xin-lai/Magicodes.DynamicSqlApi)** |
| Magicodes.DynamicSqlApi.SqlServer | 根据SQL自动解析生成动态API |   [![NuGet](https://buildstats.info/nuget/Magicodes.DynamicSqlApi.SqlServer)](https://www.nuget.org/packages/Magicodes.DynamicSqlApi.SqlServer)   | **[Magicodes.DynamicSqlApi](https://github.com/xin-lai/Magicodes.DynamicSqlApi)** |

## 联系我们

> #### 订阅号

关注“麦扣聊技术”微信订阅号可以获得最新文章、教程、文档。

![](./res/wechat.jpg "麦扣聊技术")


> #### QQ群

- 编程交流群<85318032>

- 产品交流群<897857351>

> #### 文档官网&官方博客

- 文档官网：<https://docs.xin-lai.com/>
- 博客：<http://www.cnblogs.com/codelove/>


> #### 其他开源库

- <https://github.com/xin-lai>
- <https://gitee.com/magicodes>

## 更新日志

### 2019.03.07 

- 【Nuget】Magicodes.SwaggerUI  3.0.2
- 【升级】支持.NET Core 3.1
- 【重构】支持自定义逻辑编写：
    - AddCustomSwaggerGen添加Action<SwaggerGenOptions, SwaggerConfigInfo>参数，可以实现自定义逻辑
    - UseCustomSwaggerUI添加Action<SwaggerUIOptions, SwaggerConfigInfo>参数，可以实现自定义逻辑

### 2019.10.21 

- 【Nuget】Magicodes.SwaggerUI  2.0.4
- 【升级】单个文档不分组，显示所有API
- 【梳理】梳理目录结构
- 【修复】修复本地开发环境运行时不加载文档注释的问题
- 【修改】自动移除GroupUrlPrefix的前后空格以及“/”前缀
- 【升级】在全局隐藏API的基础上，支持分组API隐藏
- 【升级】API隐藏支持HTTP方法配置，默认“*”

### 2019.10.19
- 【升级】支持API分组，支持非侵入式配置，无需修改代码，仅通过配置即可完成API分组（见下面示例）
- 【重构】重构整体逻辑

## Demo
### 配置Demo
```
  "SwaggerDoc": {
    "IsEnabled": "true",
    //将枚举值以字符串显示
    "DescribeAllEnumsAsStrings": false,
    "SwaggerDocInfos": [
      {
        "IsEnabled": "true",
        "Title": "APP1 API文档",
        "Version": "v1",
        "GroupName": "App1",
        "Description": "",
        "Contact": {
          "Name": "心莱科技Team1",
          "Email": "xinlai@xin-lai.com"
        },
        "GroupUrlPrefix": "api/app1/"
      },
      {
        "IsEnabled": "true",
        "Title": "APP2 API文档",
        "Version": "v2",
        "GroupName": "App2",
        "Description": "",
        "Contact": {
          "Name": "心莱科技Team2",
          "Email": "xinlai@xin-lai.com"
        },
        "GroupUrlPrefix": "api/app2/",
        "HiddenApi": {
          "IsEnabled": "true",
          "Urls": [
            {
              "Url": "app2/Values/{id}",
              "HttpMethod": "Delete"
            }
          ]
        }
      }
    ],
    "HiddenApi": {
      "IsEnabled": "true",
      "Urls": [
        { "Url": "app1/Values/{id}" }
      ]
    },
    "UseFullNameForSchemaId": "false"
  }
```

### 注入代码:

```
//添加自定义API文档生成(支持文档配置)
public IServiceProvider ConfigureServices(IServiceCollection services)
{
services.AddCustomSwaggerGen(_appConfiguration);
}

public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
{
//启用自定义API文档(支持文档配置)
app.UseCustomSwaggerUI(_appConfiguration);
}
```