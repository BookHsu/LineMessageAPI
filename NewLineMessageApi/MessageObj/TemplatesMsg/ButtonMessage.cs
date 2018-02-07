using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg
{
    /// <summary>
    /// 按鈕訊息物件
    /// </summary>
    public class ButtonMessage:TemplateBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ButtonMessage():base(TemplateType.buttons)
        {
            imageAspectRatio = ImgAspectRatioType.rectangle;
            imageSize = ImgSizeType.cover;
            imageBackgroundColor = "#FFFFFF";
            actions = new List<LineActions.TemplateActionBase>();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text">必填項目</param>
        public ButtonMessage(string Text):this()
        {
            text = Text;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Action"></param>
        public ButtonMessage(string Text,IList<LineActions.TemplateActionBase> Action):this(Text)
        {
            actions = Action.ToList();
        }

        /// <summary>縮圖網址</summary>
        public string thumbnailImageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgAspectRatioType imageAspectRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgSizeType imageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string imageBackgroundColor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40,ErrorMessage ="訊息過長")]
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 使用NewLineMessageApi.LineActions下的物件
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(4)]
        public List<LineActions.TemplateActionBase> actions { get; set; }

    }
}
