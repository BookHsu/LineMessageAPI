using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi
{
    /// <summary>使用者檔案 </summary>
    public class UserProfile
    {
        /// <summary>暱稱</summary>
        public string displayName { get; set; }

        /// <summary>大頭貼</summary>
        public string pictureUrl { get; set; }

        /// <summary>心情狀態</summary>
        public string statusMessage { get; set; }

        /// <summary>line id</summary>
        public string userId { get; set; }
    }
}
