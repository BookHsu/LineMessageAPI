using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>主動退送訊息</summary>
    internal sealed class PushMessage : SendMessage
    {
        internal PushMessage() : base()
        {

        }
        internal PushMessage(string ToId) : this()
        {
            to = ToId;
        }
        internal PushMessage(string ToId, params MessageObjectBase[] msg) : this(ToId)
        {
            if (msg.Length > 5) throw new Exception("推播訊息不可大於五");

            messages.AddRange(msg);
        }
        internal string to { get; set; }
    }
}
