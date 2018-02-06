using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
   public class UriAction:TemplateActionBase
    {
        public UriAction():base(ActionType.uri)
        {

        }
        public string uri { get; set; }
    }
}
