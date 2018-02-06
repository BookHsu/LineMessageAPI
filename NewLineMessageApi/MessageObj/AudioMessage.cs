using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.MessageObj
{
   public class AudioMessage:MessageObjectBase
    {
        public AudioMessage():base(SendMessageType.audio)
        {

        }
        /// <summary>毫秒(milliseconds)</summary>
        public int duration { get; set; }
        /// <summary>聲音網址 長度不可超過1000需以https開頭，格式限制m4a檔案大小不可超過10mb，長度必須小於一分鐘</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string originalContentUrl { get; set; }
    }
}
