namespace NewLineMessageApi
{
    public class LinePostBack
    {
        /// <summary>回傳訊息</summary>
        public string data { get; set; }
        /// <summary>DateTime Picker回傳的日期參數 只有在Datetime模式下出現</summary>
        public LineParams Params { get; set; }
    }
}