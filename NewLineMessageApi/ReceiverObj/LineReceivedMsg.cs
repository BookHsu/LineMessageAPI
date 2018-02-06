using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi
{
    /// <summary>Line物件集合</summary>
    public class LineReceivedMsg
    {
        /// <summary>事件集合</summary>
        public IEnumerable<LineEvents> events { get; set; }
    }
}
