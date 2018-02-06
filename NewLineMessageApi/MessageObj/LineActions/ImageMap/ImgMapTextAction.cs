using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.LineActions.ImageMap
{
    public class ImgMapTextAction:ImageMapActionsBase
    {
        public ImgMapTextAction():base(ActionType.message)
        {

        }
        [StringLength(400, ErrorMessage="訊息過長")]
        public string text { get; set; }
    }
}
