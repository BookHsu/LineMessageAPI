using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>回復訊息</summary>
    internal sealed class ReplyMessage : SendMessage
    {
        internal ReplyMessage(string ReplyToken) : base()
        {
            replyToken = ReplyToken;
        }

        internal ReplyMessage(string ReplyToken, params MessageObjectBase[] msg) : this(ReplyToken)
        {
            if (msg.Length > 5) throw new Exception("推播訊息不可大於五");
            messages.AddRange(msg);
        }

        /// <summary>被動回復Token</summary>
        internal string replyToken { get; set; }
    }
}
