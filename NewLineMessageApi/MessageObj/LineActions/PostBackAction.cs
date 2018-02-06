using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
    public class PostBackAction:PostBackBase
    {
        public PostBackAction():base(ActionType.postback)
        {

        }
        public string text { get; set; }
    }
}
