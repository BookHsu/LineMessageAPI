using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// Action.PostBack基底抽象類別
    /// </summary>
   public abstract class PostBackBase:TemplateActionBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="actionType"></param>
        protected PostBackBase(ActionType actionType):base(actionType)
        {

        }
        /// <summary>
        /// POSTBACK的資料
        /// </summary>
        public string data { get; set; }
    }
}
