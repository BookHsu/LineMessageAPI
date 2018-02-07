namespace NewLineMessageApi.TemplatesMsg.ColumnObj
{
    /// <summary>
    ///
    /// </summary>
    public class ImgCarouselColumn : LineColumnBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="imageurl"></param>
        public ImgCarouselColumn(string imageurl) : base()
        {
            imageUrl = imageurl;
        }

        /// <summary>
        ///
        /// </summary>
        public string imageUrl { get; set; }
    }
}