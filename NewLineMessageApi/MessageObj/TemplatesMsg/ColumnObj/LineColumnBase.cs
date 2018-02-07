using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.TemplatesMsg.ColumnObj
{
    /// <summary>
    /// Column物件基底抽象類別
    /// </summary>
    public abstract class LineColumnBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        protected LineColumnBase()
        {
            actions = new List<LineActions.LineActionsBase>();
        }

        /// <summary>
        /// 使用NewLineMessageApi.LineActions下的物件
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public List<LineActions.LineActionsBase> actions { get; set; }
    }
}
