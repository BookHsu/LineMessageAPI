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
    /// <summary>
    /// 
    /// </summary>
    public class ImageMapMessage:MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ImageMapMessage():base(SendMessageType.imagemap)
        {
            actions = new List<ImageMapActionsBase>();
            baseSize = new BaseSize();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseURL"></param>
        /// <param name="AltText"></param>
        /// <param name="actionsBase"></param>
        /// <param name="BaseSize"></param>
        public ImageMapMessage(string BaseURL,string AltText,BaseSize BaseSize=null,IList<ImageMapActionsBase> actionsBase=null):this()
        {
            baseUrl = BaseURL;
            altText = AltText;
            if (BaseSize != null) baseSize = BaseSize;
            if (actionsBase != null) actions = actionsBase.ToList();
        }

        /// <summary>浮水印文字</summary>
        [StringLength(400, ErrorMessage = "訊息過長")]
        public string altText { get; set; }

        /// <summary></summary>
        public BaseSize baseSize { get; set; }

        /// <summary>顯示圖片連結</summary>
        [StringLength(1000, ErrorMessage = "網址過長")]
        public string baseUrl { get; set; }

        /// <summary>使用名稱空間 LineActions.ImageMap下的物件 </summary>
        public List<LineActions.ImageMap.ImageMapActionsBase> actions { get; set; }
    }
}
