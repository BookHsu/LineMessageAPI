﻿using System.ComponentModel.DataAnnotations;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 圖片
    /// </summary>
    public class ImageMessage : MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ImageMessage() : base(SendMessageType.image)
        {
        }

        /// <summary>圖片網址 長度不可超過1000需以https開頭，格式限制jpeg檔案大小不可超過1mb，圖片大小最大1024*1024</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string originalContentUrl { get; set; }

        /// <summary>預覽圖片 長度不可超過1000需以https開頭，格式限制jpeg檔案大小不可超過1mb，240*240</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string previewImageUrl { get; set; }
    }
}