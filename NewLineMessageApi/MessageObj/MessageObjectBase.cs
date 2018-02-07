using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 訊息基底類別
    /// </summary>
  public abstract  class MessageObjectBase
    {
        /// <summary>類型</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SendMessageType type { get;protected set; }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="messageType"></param>
        protected MessageObjectBase(SendMessageType messageType)
        {
            type = messageType;
        }
    }
}
