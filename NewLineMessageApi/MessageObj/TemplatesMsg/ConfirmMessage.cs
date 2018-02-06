using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg
{
    public class ConfirmMessage:TemplateBase
    {
        public ConfirmMessage():base(TemplateType.confirm)
        {

        }
        public string text { get; set; }
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public IEnumerable<LineActions.TemplateActionBase> actions { get; set; }
    }
}
