namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// LineAction基底抽象類別
    /// </summary>
    public abstract class LineActionsBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="actionType"></param>
        protected LineActionsBase(ActionType actionType)
        {
            type = actionType;
        }

        /// <summary>
        /// Action Type
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ActionType type { get; protected set; }
    }
}