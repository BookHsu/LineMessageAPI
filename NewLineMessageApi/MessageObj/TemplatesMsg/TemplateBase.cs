using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.TemplatesMsg
{
    public abstract class TemplateBase
    {
        /// <summary>樣板訊息類型</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TemplateType type { get; set; }

        protected TemplateBase(TemplateType templateType)
        {
            type = templateType;
        }
    }
}
