using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>
    /// 傳送訊息給大量使用者
    /// </summary>
    internal sealed class MulticastMessage: SendMessage
    {
        internal MulticastMessage():base()
        {
            to = new string[150];
        }
        internal MulticastMessage(params MessageObjectBase [] msg):this()
        {
            if (msg.Length>5) throw new Exception("推播訊息不可大於五");

            messages.AddRange(msg);
        }
        internal MulticastMessage(IList<string>To,params MessageObjectBase[] msg):this(msg)
        {
            to = To.ToArray();
        }
        internal string [] to { get; set; }
    }
}
