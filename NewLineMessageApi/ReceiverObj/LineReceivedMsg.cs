using System.Collections.Generic;

namespace NewLineMessageApi
{
    /// <summary>Line物件集合</summary>
    public class LineReceivedMsg
    {
        /// <summary>事件集合</summary>
        public IEnumerable<LineEvents> events { get; set; }
    }
}