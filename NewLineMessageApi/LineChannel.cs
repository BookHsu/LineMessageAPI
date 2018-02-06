using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NewLineMessageApi.MessageObj;

namespace NewLineMessageApi
{
    /// <summary>主動調用Line物件</summary>
    public class LineChannel
    {
        /// <summary>channelAccessToken</summary>
        public string channelAccessToken { get; set; }
        /// <summary>
        /// 初始化物件
        /// </summary>
        /// <param name="ChannelAccessToken"></param>
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
        public static bool VaridateSignature(HttpRequestMessage request, string ChannelSecret)
        {
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ChannelSecret));
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(request.Content.ReadAsStringAsync().Result));
            var contentHash = Convert.ToBase64String(computeHash);
            var headerHash = request.Headers.GetValues("X-Line-Signature").First();
            return contentHash == headerHash;
        }
        #region 
        /// <summary>
        /// 離開群組或對話
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool Leave(string sourceId, SourceType type)
        {
            if (type == SourceType.user) throw new NotSupportedException("無法使用 SourceType = User");
            return MessageApi.LeaveRoomorGroup(this.channelAccessToken, sourceId, type);
        }
        /// <summary>
        /// 離開對話或群組
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public UserProfile GetUserProfile(string userid)
        {
            return MessageApi.GetUserProfile(this.channelAccessToken, userid);
        }
        /// <summary>取得大量使用者檔案</summary>
        /// <param name="userids"></param>
        /// <returns></returns>
        public IEnumerable<UserProfile> GetUserProfiles(List<string> userids)
        {
            foreach (var userid in userids)
            {
                yield return MessageApi.GetUserProfile(this.channelAccessToken, userid);
            }

        }
        /// <summary>
        /// 取得群組或多人對談中指定使用者檔案
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="GroupIdOrRoomId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public UserProfile GetGroupOrRoomUserProfile(string userid, string GroupIdOrRoomId, SourceType type)
        {
            if (type == SourceType.user) throw new NotSupportedException("無法使用 SourceType = User");

            return MessageApi.GetUserProfile(channelAccessToken, userid, GroupIdOrRoomId, type);
        }
        /// <summary>
        /// 取得使用者上傳的資料(圖片、影片、聲音)
        /// </summary>
        /// <param name="message_id"></param>
        /// <returns></returns>
        public byte[] GetUserUpload(string message_id)
        {
            return MessageApi.GetContnt(this.channelAccessToken, message_id);
        }
        /// <summary>傳送訊息給多位使用者</summary>
        /// <param name="ToId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool SendMuticastMessage(IList<string> ToId, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageAction(this.channelAccessToken, PostMessageType.Multicast, new MulticastMessage(ToId, message));
        }
        /// <summary>
        /// 主動傳送訊息
        /// </summary>
        /// <param name="ToId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool SendPushMessage(string ToId, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageAction(channelAccessToken, PostMessageType.Push, new PushMessage(ToId, message));
        }
        /// <summary>
        /// 被動回復訊息
        /// </summary>
        /// <param name="ReplyToken"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool SendReplyMessage(string ReplyToken, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageAction(this.channelAccessToken, PostMessageType.Reply, new ReplyMessage(ReplyToken, message));
        }
        #endregion
        #region Async
        /// <summary>
        /// .Net 4.5 非同步方法
        /// 離開群組或對話
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Task<bool> LeaveAsync(string sourceId, SourceType type)
        {
            if (type == SourceType.user) throw new NotSupportedException("無法使用 SourceType = User");
            return MessageApi.LeaveRoomorGroupAsync(this.channelAccessToken, sourceId, type);
        }
        /// <summary>
        ///  .Net 4.5 非同步方法
        /// 離開對話或群組
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Task<UserProfile> GetUserProfileAsync(string userid)
        {
            return MessageApi.GetUserProfileAsync(this.channelAccessToken, userid);
        }
        /// <summary>
        ///  .Net 4.5 非同步方法
        /// 取得大量使用者檔案</summary>
        /// <param name="userids"></param>
        /// <returns></returns>
        public async Task<IEnumerable<UserProfile>> GetUserProfilesAsync(List<string> userids)
        {
            List<UserProfile> list = new List<UserProfile>();
            foreach (var userid in userids)
            {
                list.Add(await MessageApi.GetUserProfileAsync(this.channelAccessToken, userid));
            }
            return list.AsEnumerable();
        }
        /// <summary>
        ///  .Net 4.5 非同步方法
        /// 取得群組或多人對談中指定使用者檔案
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="GroupIdOrRoomId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Task<UserProfile> GetGroupOrRoomUserProfileAsync(string userid, string GroupIdOrRoomId, SourceType type)
        {
            if (type == SourceType.user) throw new NotSupportedException("無法使用 SourceType = User");

            return MessageApi.GetUserProfileAsync(channelAccessToken, userid, GroupIdOrRoomId, type);
        }
        /// <summary>
        ///  .Net 4.5 非同步方法
        /// 取得使用者上傳的資料(圖片、影片、聲音)
        /// </summary>
        /// <param name="message_id"></param>
        /// <returns></returns>
        public Task<byte[]> GetUserUploadAsync(string message_id)
        {
            return MessageApi.GetContntAsync(this.channelAccessToken, message_id);
        }
        /// <summary>        
        ///   .Net 4.5 非同步方法
        /// 傳送訊息給多位使用者
        /// </summary>
        /// <param name="ToId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task<bool> SendMuticastMessageAsync(IList<string> ToId, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageActionAsync(this.channelAccessToken, PostMessageType.Multicast, new MulticastMessage(ToId, message));
        }
        /// <summary>        
        ///   .Net 4.5 非同步方法
        /// 主動傳送訊息
        /// </summary>
        /// <param name="ToId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task<bool> SendPushMessageAsync(string ToId, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageActionAsync(channelAccessToken, PostMessageType.Push, new PushMessage(ToId, message));
        }
        /// <summary>        
        ///  .Net 4.5 非同步方法
        /// 被動回復訊息
        /// </summary>
        /// <param name="ReplyToken"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task<bool> SendReplyMessageAsync(string ReplyToken, params MessageObjectBase[] message)
        {
            return MessageApi.SendMessageActionAsync(this.channelAccessToken, PostMessageType.Reply, new ReplyMessage(ReplyToken, message));
        }
        #endregion
    }
}
