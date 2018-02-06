using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.LineActions.ImageMap
{
    public class ImgMapUriAction:ImageMapActionsBase
    {
        public ImgMapUriAction():base(ActionType.uri)
        {

        }
        /// <summary>連結網址 imagemap</summary>
        public string linkUri { get; set; }
    }
}
