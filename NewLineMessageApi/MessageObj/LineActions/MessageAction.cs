namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// 文字Action
    /// </summary>
    public class MessageAction : TemplateActionBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public MessageAction() : base(ActionType.message)
        {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text"></param>
        public MessageAction(string Text) : this()
        {
            text = Text;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Text">必填項目</param>
        /// <param name="Label">除image carousel外皆必填</param>
        public MessageAction(string Text, string Label) : this(Text)
        {
            label = Label;
        }

        /// <summary>
        /// 必填
        /// </summary>
        public string text { get; set; }
    }
}