using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewLineMessageApi.MessageObj
{
    /// <summary>貼圖</summary>
    public class StickerMessage:MessageObjectBase
    {
        /// <summary></summary>
        public StickerMessage():base(SendMessageType.sticker)
        {

        }
        /// <summary></summary>
        public StickerMessage(int IpackageId, int IstickerId) : this()
        {
            packageId = IpackageId.ToString();
            stickerId = IstickerId.ToString();
        }

        /// <summary></summary>
        public StickerMessage(string spackageId, string sstickerId) : this()
        {
            packageId = spackageId.ToString();
            stickerId = sstickerId.ToString();
        }

        /// <summary>傳送貼圖 對應https://devdocs.line.me/files/sticker_list.pdf 中的STKPKGID</summary>
        public string packageId { get; set; }

        /// <summary>傳送貼圖 對應https://devdocs.line.me/files/sticker_list.pdf 中的STKGID</summary>
        public string stickerId { get; set; }
    }
}
