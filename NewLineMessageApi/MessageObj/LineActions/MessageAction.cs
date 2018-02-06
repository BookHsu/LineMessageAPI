using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
    public class MessageAction:TemplateActionBase
    {
        public MessageAction():base(ActionType.message)
        {

        }
        public string text { get; set; }
    }
}
