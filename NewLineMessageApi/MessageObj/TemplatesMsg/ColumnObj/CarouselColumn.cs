using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg.ColumnObj
{
    public class CarouselColumn : LineColumnBase
    {
        public CarouselColumn()
        {
            imageBackgroundColor = "#FFFFFF";
        }
        /// <summary>文字訊息(必填)</summary> 
        public string text { get; set; }

        /// <summary>縮圖網址 https jpeg or png max 1mb (非必填)</summary>
        public string thumbnailImageUrl { get; set; }

        public string imageBackgroundColor { get; set; }
        /// <summary>標題(非必填)</summary>
        public string title { get; set; }

    }
}
