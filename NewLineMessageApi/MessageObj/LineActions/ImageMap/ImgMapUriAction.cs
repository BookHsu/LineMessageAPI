using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.LineActions.ImageMap
{
    /// <summary>
    /// Imagemap專用Action
    /// </summary>
    public class ImgMapUriAction:ImageMapActionsBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ImgMapUriAction():base(ActionType.uri)
        {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="LinkURI">必填項目</param>
        public ImgMapUriAction(string LinkURI):this()
        {
            linkUri = LinkURI;
        }
        /// <summary>連結網址 imagemap</summary>
        public string linkUri { get; set; }
    }
}
