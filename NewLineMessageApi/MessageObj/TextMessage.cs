﻿using System.ComponentModel.DataAnnotations;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>文字訊息</summary>
    public class TextMessage : MessageObjectBase
    {
        /// <summary></summary>
        public TextMessage() : base(SendMessageType.text)
        {
        }

        /// <summary>直接傳入文字訊息</summary>
        /// <param name="message"></param>
        public TextMessage(string message) : this()
        {
            text = message;
        }

        /// <summary>想說的話，長度不可超過2000</summary>
        [StringLength(2000, ErrorMessage = "訊息過長")]
        public string text { get; set; }
    }
}