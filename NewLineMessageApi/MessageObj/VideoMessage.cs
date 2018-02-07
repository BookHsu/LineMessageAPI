using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 影片訊息
    /// </summary>
   public class VideoMessage:MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public VideoMessage():base( SendMessageType.video)
        {
        }

        /// <summary>影片網址 長度不可超過1000需以https開頭，格式限制mp4檔案大小不可超過10mb，影片長度不可超過一分鐘</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string originalContentUrl { get; set; }
        /// <summary>預覽圖片 長度不可超過1000需以https開頭，格式限制jpeg檔案大小不可超過1mb，240*240</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string previewImageUrl { get; set; }
    }
}
