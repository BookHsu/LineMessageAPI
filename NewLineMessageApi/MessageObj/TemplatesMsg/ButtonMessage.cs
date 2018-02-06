using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg
{
    public class ButtonMessage:TemplateBase
    {
        public ButtonMessage():base(TemplateType.buttons)
        {
            imageAspectRatio = ImgAspectRatioType.rectangle;
            imageSize = ImgSizeType.cover;
            imageBackgroundColor = "#FFFFFF";
        }
        /// <summary>縮圖網址</summary>
        public string thumbnailImageUrl { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgAspectRatioType imageAspectRatio { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgSizeType imageSize { get; set; }
        public string imageBackgroundColor { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(40,ErrorMessage ="訊息過長")]
        public string title { get; set; }
        public string text { get; set; }
        [System.ComponentModel.DataAnnotations.MaxLength(4)]
        public IEnumerable<LineActions.TemplateActionBase> actions { get; set; }

    }
}
