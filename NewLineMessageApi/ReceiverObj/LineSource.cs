using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi
{
    /// <summary>訊息來源主要物件
    /// 使用者直接對談：userId
    /// 群組對話：groupId userId
    /// 房間對話：roomId userId
    /// </summary>
    public class LineSource
    {
        /// <summary>群組id</summary>
        public string groupId { get; set; }
        /// <summary>房間id</summary>
        public string roomId { get; set; }
        /// <summary>訊息來源類型</summary>
        public SourceType type { get; set; }
        /// <summary>使用者id</summary>
        public string userId { get; set; }

    }
}
