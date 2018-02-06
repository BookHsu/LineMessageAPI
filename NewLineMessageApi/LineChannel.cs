using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewLineMessageApi
{
    public class LineChannel
    {
        public string channelAccessToken { get; set; }
        public LineChannel(string ChannelAccessToken)
        {
            this.channelAccessToken = channelAccessToken;

        }
        /// <summary>
        /// 驗證是否為伺服器訊息
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ChannelSecret"></param>
        /// <returns></returns>
        public static bool VaridateSignature(HttpRequestMessage request,string ChannelSecret)
        {
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ChannelSecret));
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Content.ReadAsStringAsync().Result));
            var contentHash = Convert.ToBase64String(computeHash);
            var headerHash = request.Headers.GetValues("X-Line-Signature").First();
            return contentHash == headerHash;
        }
    }
}
