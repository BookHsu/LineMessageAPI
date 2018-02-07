using System.Collections.Generic;
using System.Linq;

namespace NewLineMessageApi.TemplatesMsg
{
    /// <summary>
    ///
    /// </summary>
    public class ImageCarouselMessage : TemplateBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ImageCarouselMessage() : base(TemplateType.image_carousel)
        {
            columns = new List<ColumnObj.ImgCarouselColumn>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="imgCarouselColumn"></param>
        public ImageCarouselMessage(IList<ColumnObj.ImgCarouselColumn> imgCarouselColumn) : this()
        {
            columns = imgCarouselColumn.ToList();
        }

        /// <summary>
        /// 使用NewLineMessageApi.TemplatesMsg.ColumnObj
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public List<ColumnObj.ImgCarouselColumn> columns { get; set; }
    }
}