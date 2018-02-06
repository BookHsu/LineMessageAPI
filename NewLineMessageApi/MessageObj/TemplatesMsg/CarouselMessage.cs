using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg
{
    public class CarouselMessage:TemplateBase
    {
        public CarouselMessage():base(TemplateType.carousel)
        {
            imageAspectRatio = ImgAspectRatioType.rectangle;
            imageSize = ImgSizeType.cover;
        }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgAspectRatioType imageAspectRatio { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ImgSizeType imageSize { get; set; }
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public IEnumerable<ColumnObj.CarouselColumn> columns { get; set; }
    }
}
