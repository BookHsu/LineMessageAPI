using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.MessageObj
{
  public abstract  class MessageObjectBase
    {
        /// <summary>類型</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SendMessageType type { get; set; }
        protected MessageObjectBase(SendMessageType messageType)
        {
            type = messageType;
        }
    }
}
