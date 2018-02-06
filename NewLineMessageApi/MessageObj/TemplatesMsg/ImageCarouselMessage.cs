using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg
{
   public class ImageCarouselMessage: TemplateBase
    {
        public ImageCarouselMessage():base(TemplateType.image_carousel)
        {

        }
        [System.ComponentModel.DataAnnotations.MaxLength(10)]
        public IEnumerable<ColumnObj.ImgCarouselColumn> columns { get; set; }
    }
}
