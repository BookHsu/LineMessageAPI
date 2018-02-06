using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
    public abstract class LineActionsBase
    {
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ActionType type { get; set; }
        protected LineActionsBase(ActionType actionType)
        {
            type = actionType;
        }
    }
}
