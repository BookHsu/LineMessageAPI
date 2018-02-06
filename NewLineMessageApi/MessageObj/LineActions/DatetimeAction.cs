using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi.LineActions
{
   public class DatetimeAction:PostBackBase
    {
        public DatetimeAction():base(ActionType.datetimepicker)
        {

        }
        /// <summary>Datetime Picker</summary>
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DateTimePickerType mode { get; set; }
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
    }
}
