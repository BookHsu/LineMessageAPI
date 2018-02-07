namespace NewLineMessageApi.MessageObj
{
    /// <summary>貼圖</summary>
    public class StickerMessage : MessageObjectBase
    {
        /// <summary>初始化</summary>
        public StickerMessage() : base(SendMessageType.sticker)
        {
        }

        /// <summary>直接傳入參數</summary>
        /// <param name="IpackageId">STKPKGID</param>
        /// <param name="IstickerId">STKGID</param>
        public StickerMessage(int IpackageId, int IstickerId) : this()
        {
            packageId = IpackageId.ToString();
            stickerId = IstickerId.ToString();
        }

        /// <summary>直接傳入參數</summary>
        /// <param name="spackageId">STKPKGID</param>
        /// <param name="sstickerId">STKGID</param>
        public StickerMessage(string spackageId, string sstickerId) : this()
        {
            packageId = spackageId;
            stickerId = sstickerId;
        }

        /// <summary>傳送貼圖 對應https://devdocs.line.me/files/sticker_list.pdf 中的STKPKGID</summary>
        public string packageId { get; set; }

        /// <summary>傳送貼圖 對應https://devdocs.line.me/files/sticker_list.pdf 中的STKGID</summary>
        public string stickerId { get; set; }
    }
}