namespace NewLineMessageApi.LineActions.ImageMap
{
    /// <summary>ImageMap Message 專用</summary>
    public class BaseSize
    {
        /// <summary>Default height=1024 width=1024 </summary>
        public BaseSize()
        {
            height = 1024;
            width = 1024;
        }

        /// <summary></summary>
        public int height { get; set; }

        /// <summary></summary>
        public int width { get; set; }
    }
}