using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
   public abstract class TemplateActionBase:LineActionsBase
    {
        protected TemplateActionBase(ActionType actionType):base(actionType)
        {

        }
        public string label { get; set; }
    }
}
