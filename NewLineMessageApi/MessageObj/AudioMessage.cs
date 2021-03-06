﻿using System.ComponentModel.DataAnnotations;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 聲音訊息
    /// </summary>
    public class AudioMessage : MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public AudioMessage() : base(SendMessageType.audio)
        {
        }

        /// <summary>毫秒(milliseconds)</summary>
        public int duration { get; set; }

        /// <summary>聲音網址 長度不可超過1000需以https開頭，格式限制m4a檔案大小不可超過10mb，長度必須小於一分鐘</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string originalContentUrl { get; set; }
    }
}