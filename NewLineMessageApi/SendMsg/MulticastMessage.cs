using System;
using System.Collections.Generic;
using System.Linq;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>
    /// 傳送訊息給大量使用者
    /// </summary>
    public sealed class MulticastMessage : SendMessage
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public MulticastMessage() : base()
        {
            to = new string[150];
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="msg"></param>
        public MulticastMessage(params MessageObjectBase[] msg) : this()
        {
            if (msg.Length > 5) throw new Exception("推播訊息不可大於五");

            messages.AddRange(msg);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="To"></param>
        /// <param name="msg"></param>
        public MulticastMessage(IList<string> To, params MessageObjectBase[] msg) : this(msg)
        {
            to = To.ToArray();
        }

        /// <summary>
        ///
        /// </summary>
        public string[] to { get; set; }
    }
}