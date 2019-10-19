// ======================================================================
// 
//           Copyright (C) 2019-2030 湖南心莱信息科技有限公司
//           All rights reserved
// 
//           filename : HiddenApiConfig.cs
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
    /// API隐藏配置
    /// </summary>
    public class HiddenApiConfig
    {
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 多个隐藏路径配置，使用逗号分隔。允许填写部分路径。
        /// </summary>
        public string HiddenUrls { get; set; }
    }
}