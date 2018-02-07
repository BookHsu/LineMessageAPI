using System.Collections.Generic;
using System.Linq;

namespace NewLineMessageApi.TemplatesMsg
{
    /// <summary>
    /// 表格式訊息
    /// </summary>
    public class CarouselMessage : TemplateBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public CarouselMessage() : base(TemplateType.carousel)
        {
            imageAspectRatio = ImgAspectRatioType.rectangle;
            imageSize = ImgSizeType.cover;
            columns = new List<ColumnObj.CarouselColumn>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="column"></param>
        public CarouselMessage(IList<ColumnObj.CarouselColumn> column) : this()
        {
            columns = column.ToList();
        }

        /// <summary>
        /// 使用NewLineMessageApi.TemplatesMsg.ColumnObj下的物件
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public List<ColumnObj.CarouselColumn> columns { get; set; }

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
    }
}