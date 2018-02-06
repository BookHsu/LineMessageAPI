using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.LineActions;
using NewLineMessageApi.LineActions.ImageMap;

namespace NewLineMessageApi.MessageObj
{
    public class ImageMapMessage:MessageObjectBase
    {
        public ImageMapMessage():base(SendMessageType.imagemap)
        {

        }
        //TODO
        /// <summary>浮水印文字</summary>
        [StringLength(400, ErrorMessage = "訊息過長")]
        public string altText { get; set; }

        /// <summary></summary>
        public BaseSize baseSize { get; set; }

        /// <summary>顯示圖片連結</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string baseUrl { get; set; }

        /// <summary>使用名稱空間 LineActions.ImageMap下的物件 </summary>
        public IEnumerable<LineActions.ImageMap.ImageMapActionsBase> actions { get; set; }
    }
}
