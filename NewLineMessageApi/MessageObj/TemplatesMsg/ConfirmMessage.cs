using System.Collections.Generic;
using System.Linq;

namespace NewLineMessageApi.TemplatesMsg
{
    /// <summary>
    /// 確認訊息
    /// </summary>
    public class ConfirmMessage : TemplateBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public ConfirmMessage() : base(TemplateType.confirm)
        {
            actions = new List<LineActions.TemplateActionBase>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text"></param>
        public ConfirmMessage(string Text) : this()
        {
            text = Text;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Actions"></param>
        public ConfirmMessage(string Text, IList<LineActions.TemplateActionBase> Actions) : this(Text)
        {
            actions = actions.ToList();
        }

        /// <summary>
        /// 使用NewLineMessageApi.LineActions下的物件
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(2)]
        public List<LineActions.TemplateActionBase> actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string text { get; set; }
    }
}