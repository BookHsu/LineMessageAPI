namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// 網址連結Action
    /// </summary>
    public class UriAction : TemplateActionBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public UriAction() : base(ActionType.uri)
        {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="URI"></param>
        public UriAction(string URI) : this()
        {
            uri = URI;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="URI"></param>
        /// <param name="Label">除image carousel外皆必填</param>
        public UriAction(string URI, string Label) : this(URI)
        {
            label = Label;
        }

        /// <summary>
        /// 網址 Must start with http, https, or tel.
        /// </summary>
        public string uri { get; set; }
    }
}