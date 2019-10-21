// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : SwaggerDocInfo.cs
//           description :
// 
//           created by 雪雁 at  -- 
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

namespace Magicodes.SwaggerUI.Models
{
    /// <summary>
    /// API文档信息
    /// </summary>
    public class SwaggerDocInfo
    {
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 文档标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        public string GroupName { get; set; } = "v1";

        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; } = "v1";

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 联系信息
        /// </summary>
        public ContactInfo Contact { get; set; }

        /// <summary>
        /// 分组Url前缀
        /// </summary>
        public string GroupUrlPrefix { get; set; }

        /// <summary>
        /// 隐藏API配置
        /// </summary>
        public HiddenApiConfigInfo HiddenApi { get; set; }
    }
}