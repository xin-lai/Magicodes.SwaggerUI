using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.SwaggerUI.Models
{
    /// <summary>
    /// Swagger配置信息
    /// </summary>
    public class SwaggerConfigInfo
    {
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }


        /// <summary>
        /// 将枚举值以字符串显示
        /// </summary>
        public bool DescribeAllEnumsAsStrings { get; set; }

        /// <summary>
        /// Api文档列表
        /// </summary>
        public List<SwaggerDocInfo> SwaggerDocInfos { get; set; }

        /// <summary>
        /// 在界面上显示验证（Authorize）按钮，验证按钮处理逻辑基于 wwwroot/swagger/ui/index.html
        /// </summary>
        public bool Authorize { get; set; }

        /// <summary>
        /// 隐藏API配置
        /// </summary>
        public HiddenApiConfig HiddenApi { get; set; }

        /// <summary>
        /// 是否启用API全名
        /// </summary>
        public bool UseFullNameForSchemaId { get; set; }

        /// <summary>
        /// 需要从嵌入资源中加载的程序集全称
        /// </summary>
        public string ManifestResourceAssembly { get; set; }

        /// <summary>
        /// 嵌入资源路径
        /// </summary>
        public string ManifestResourceUrl { get; set; }

    }
}
