using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg.ColumnObj
{
    public abstract class LineColumnBase
    {
        public LineColumnBase()
        {

        }
       
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public IEnumerable<LineActions.LineActionsBase> actions { get; set; }
    }
}
