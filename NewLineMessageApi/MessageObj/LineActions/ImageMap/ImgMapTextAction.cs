using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.LineActions.ImageMap
{
    /// <summary>
    /// Image專用Action
    /// </summary>
    public class ImgMapTextAction:ImageMapActionsBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ImgMapTextAction():base(ActionType.message)
        {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text">必填項目</param>
        public ImgMapTextAction(string Text):this()
        {
            text = Text;
        }
        /// <summary>
        /// 文字
        /// </summary>
        [StringLength(400, ErrorMessage="訊息過長")]
        public string text { get; set; }
    }
}
