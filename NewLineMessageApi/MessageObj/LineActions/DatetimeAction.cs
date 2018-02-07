namespace NewLineMessageApi.LineActions
{
    /// <summary>
    /// 日期選擇
    /// </summary>
    public class DatetimeAction : PostBackBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public DatetimeAction() : base(ActionType.datetimepicker)
        {
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Data"></param>
        public DatetimeAction(string Data) : this()
        {
            data = Data;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Mode"></param>
        public DatetimeAction(string Data, DateTimePickerType Mode) : this(Data)
        {
            mode = Mode;
        }

        /// <summary>
        /// 日期或時間的初始值
        /// </summary>
        public string initial { get; set; }

        /// <summary>
        /// 日期或時間的最大值
        /// </summary>
        public string max { get; set; }

        /// <summary>
        /// 日期或時間的最小值
        /// </summary>
        public string min { get; set; }

        /// <summary>Datetime Picker</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DateTimePickerType mode { get; set; }
    }
}