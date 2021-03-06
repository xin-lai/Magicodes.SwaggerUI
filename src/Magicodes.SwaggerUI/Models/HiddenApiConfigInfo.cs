﻿// ======================================================================
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

using System.Collections.Generic;

namespace Magicodes.SwaggerUI.Models
{
    /// <summary>
    /// API隐藏配置
    /// </summary>
    public class HiddenApiConfigInfo
    {
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiConfigInfo> Urls { get; set; }
    }
}