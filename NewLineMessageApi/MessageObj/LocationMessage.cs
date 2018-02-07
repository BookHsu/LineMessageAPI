using System.ComponentModel.DataAnnotations;

namespace NewLineMessageApi.MessageObj
{
    /// <summary>
    /// 地理位置
    /// </summary>
    public class LocationMessage : MessageObjectBase
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public LocationMessage() : base(SendMessageType.location)
        {
        }

        /// <summary>地址</summary>
        [StringLength(1000, ErrorMessage = "訊息過長")]
        public string address { get; set; }

        /// <summary>緯度</summary>
        public double latitude { get; set; }

        /// <summary>經度</summary>
        public double longitude { get; set; }

        /// <summary>標題</summary>
        [StringLength(1000, ErrorMessage = "訊息過長")]
        public string title { get; set; }
    }
}