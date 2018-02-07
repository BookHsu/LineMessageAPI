using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>
    /// 傳送訊息基底類別
    /// </summary>
    public abstract class SendMessage
    {
        /// <summary>
        /// 
        /// </summary>
        protected SendMessage()
        {
            messages = new List<MessageObjectBase>();
        }
        /// <summary>傳送訊息</summary>
        [MaxLength(5, ErrorMessage = "訊息不可大於五")]
        public List<MessageObjectBase> messages { get; set; }
    }
}
