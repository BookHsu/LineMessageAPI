using System.Collections.Generic;

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