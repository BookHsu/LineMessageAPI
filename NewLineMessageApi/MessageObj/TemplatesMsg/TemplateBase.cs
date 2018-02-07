﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.TemplatesMsg
{
    /// <summary>
    /// 樣板訊息基底抽象類別
    /// </summary>
    public abstract class TemplateBase
    {
        /// <summary>樣板訊息類型</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TemplateType type { get;protected set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="templateType"></param>
        protected TemplateBase(TemplateType templateType)
        {
            type = templateType;
        }
    }
}
