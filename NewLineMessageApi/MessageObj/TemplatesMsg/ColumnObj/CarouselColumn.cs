using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg.ColumnObj
{
    /// <summary>
    /// 表格式訊息欄位
    /// </summary>
    public class CarouselColumn : LineColumnBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public CarouselColumn():base()
        {
            imageBackgroundColor = "#FFFFFF";
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public CarouselColumn(string Text):this()
        {
            text = Text;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Action"></param>
        public CarouselColumn(string Text,IList<LineActions.LineActionsBase> Action):this(Text)
        {
            base.actions = Action.ToList();
        }
        /// <summary>文字訊息(必填)</summary> 
        public string text { get; set; }

        /// <summary>縮圖網址 https jpeg or png max 1mb (非必填)</summary>
        public string thumbnailImageUrl { get; set; }
        /// <summary>
        /// 預設#FFFFFF
        /// </summary>
        public string imageBackgroundColor { get; set; }
        /// <summary>標題(非必填)</summary>
        public string title { get; set; }

    }
}
