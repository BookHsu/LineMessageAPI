using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.MessageObj
{
    public class TemplateMessage:MessageObjectBase
    {
        public TemplateMessage():base(SendMessageType.template)
        {

        }
        /// <summary>替代訊息(必填)</summary>
        public string altText { get; set; }
        public TemplatesMsg.TemplateBase template { get; set; }

    }
}
