using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.MessageObj
{
    public class LocationMessage:MessageObjectBase
    {
        public LocationMessage():base(SendMessageType.location)
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
