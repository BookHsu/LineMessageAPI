using System;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>主動退送訊息</summary>
    public sealed class PushMessage : SendMessage
    {
        /// <summary>
        ///
        /// </summary>
        public PushMessage() : base()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ToId"></param>
        public PushMessage(string ToId) : this()
        {
            to = ToId;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ToId"></param>
        /// <param name="msg"></param>
        public PushMessage(string ToId, params MessageObjectBase[] msg) : this(ToId)
        {
            if (msg.Length > 5) throw new Exception("推播訊息不可大於五");

            messages.AddRange(msg);
        }

        /// <summary>
        ///
        /// </summary>
        public string to { get; set; }
    }
}