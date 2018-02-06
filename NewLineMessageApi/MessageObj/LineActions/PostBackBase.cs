using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
   public abstract class PostBackBase:TemplateActionBase
    {
        protected PostBackBase(ActionType actionType):base(actionType)
        {

        }
        public string data { get; set; }
    }
}
