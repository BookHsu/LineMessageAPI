namespace NewLineMessageApi.LineActions.ImageMap
{
    /// <summary>
    /// Imagemap專用Action抽象基底類別
    /// </summary>
    public abstract class ImageMapActionsBase : LineActionsBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="type"></param>
        protected ImageMapActionsBase(ActionType type) : base(type)
        {
        }

        /// <summary>
        /// 必填項目
        /// </summary>
        public ImageMapArea area { get; set; }
    }
}