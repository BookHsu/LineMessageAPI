namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// Template專用Action基底抽象類別
    /// </summary>
    public abstract class TemplateActionBase : LineActionsBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="actionType"></param>
        protected TemplateActionBase(ActionType actionType) : base(actionType)
        {
        }

        /// <summary>
        /// 除image carousel外皆必填
        /// </summary>
        public string label { get; set; }
    }
}