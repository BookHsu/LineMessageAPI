using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// PostBack.Action
    /// </summary>
    public class PostBackAction:PostBackBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public PostBackAction():base(ActionType.postback)
        {

        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Data">必填項目</param>
        public PostBackAction(string Data):this()
        {
            data = Data;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Data">必填項目</param>
        /// <param name="Label">除image carousel外皆必填</param>
        public PostBackAction(string Data, string Label) : this(Data)
        {
            label = Label;
        }

        /// <summary>
        /// (可選)
        /// </summary>
        public string text { get; set; }
    }
}
