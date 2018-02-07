using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 樣板訊息
    /// </summary>
    public class TemplateMessage:MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public TemplateMessage():base(SendMessageType.template)
        {

        }
        /// <summary>替代訊息(必填)</summary>
        public string altText { get; set; }
        /// <summary>
        /// 使用NewLineMessageApi.TemplatesMsg下的物件
        /// </summary>
        public TemplatesMsg.TemplateBase template { get; set; }

    }
}
