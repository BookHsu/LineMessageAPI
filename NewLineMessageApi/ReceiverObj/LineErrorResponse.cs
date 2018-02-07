using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi
{
    /// <summary>
    /// 錯誤訊息元件
    /// </summary>
   public class LineErrorResponse
    {
        /// <summary></summary>
        public List<ErrorDetail> details { get; set; }

        /// <summary></summary>
        public string message { get; set; }
    }
}
