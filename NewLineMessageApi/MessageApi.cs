using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewLineMessageApi
{
    internal static class MessageApi
    {

        private static HttpClient client;
        #region Private

        private static void SetClient(string ChannelAccessToken)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ChannelAccessToken);
        }
        private static Exception throwLineErrorMsg(string result)
        {
            LineErrorResponse err = JsonConvert.DeserializeObject<LineErrorResponse>(result);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(err.message + ",");
            foreach (var item in err.details)
            {
                sb.AppendLine(string.Format("{0},{1}", item.property, item.message));
            }
            return new Exception(sb.ToString());

        }
        #endregion
        #region 
        /// <summary>取得使用者傳送的 圖片 影片 聲音 檔案</summary>
        /// <param name="ChannelAccessToken"></param> 
        /// <param name="message_id"></param>
        /// <returns></returns>
        internal static byte[] GetContnt(string ChannelAccessToken, string message_id)
        {
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/message/{0}/content", message_id);
                var result = client.GetByteArrayAsync(strUrl).Result;
                return result;

            }
            finally
            {
                client.Dispose();
            }

        }

        /// <summary>取得使用者檔案</summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        internal static UserProfile GetUserProfile(string ChannelAccessToken, string userid)
        {
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/profile/{0}", userid);
                var result = client.GetStringAsync(strUrl).Result;
                return JsonConvert.DeserializeObject<UserProfile>(result);

            }
            finally
            {
                client.Dispose();
            }

        }

        /// <summary>
        /// 取得群組或對話內指定成員的使用者檔案
        /// </summary>
        /// <param name="channelAccessToken"></param>
        /// <param name="userId"></param>
        /// <param name="groupIdorRoomId"></param>
        /// <returns></returns>
        internal static UserProfile GetUserProfile(string channelAccessToken, string userId, string groupIdorRoomId, SourceType type)
        {
            if (client == null) SetClient(channelAccessToken);
            try
            {

                string strUrl = string.Format("https://api.line.me/v2/bot/{0}/{1}/member/{2}", type.ToString(), groupIdorRoomId, userId);
                var result = client.GetStringAsync(strUrl).Result;
                return JsonConvert.DeserializeObject<UserProfile>(result);
            }
            finally
            {
                client.Dispose();
            }
        }
        /// <summary>離開群組或對話</summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static bool LeaveRoomorGroup(string ChannelAccessToken, string id, SourceType type)
        {
            bool flag = false;
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/{0}/{1}/leave", type.ToString(), id);
                var result = client.PostAsync(strUrl, new StringContent("")).Result;
                flag = result.IsSuccessStatusCode;
            }
            finally
            {
                client.Dispose();
            }
            return flag;

        }
        /// <summary>
        /// 根據傳入種類發送訊息
        /// </summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="postMessageType"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static bool SendMessageAction(string ChannelAccessToken, PostMessageType postMessageType, SendMessage message)
        {
            if (client == null) SetClient(ChannelAccessToken);

            try
            {
                string strUrl = string.Empty;
                switch (postMessageType)
                {
                    case PostMessageType.Reply:
                        strUrl = "https://api.line.me/v2/bot/message/reply";
                        break;

                    case PostMessageType.Push:
                        strUrl = "https://api.line.me/v2/bot/message/push";
                        break;

                    case PostMessageType.Multicast:
                        strUrl = "https://api.line.me/v2/bot/message/multicast";
                        break;
                }
                string sJson = JsonConvert.SerializeObject(message);
                var content = new StringContent(sJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(strUrl, content).Result;
                if (result.IsSuccessStatusCode) return true;

                throw throwLineErrorMsg(result.Content.ReadAsStringAsync().Result);

            }
            finally
            {
                client.Dispose();
            }
        }

        #endregion
        #region Async
        /// <summary>取得使用者傳送的 圖片 影片 聲音 檔案</summary>
        /// <param name="ChannelAccessToken"></param> 
        /// <param name="message_id"></param>
        /// <returns></returns>
        internal static async Task<byte[]> GetContntAsync(string ChannelAccessToken, string message_id)
        {
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/message/{0}/content", message_id);
                return await client.GetByteArrayAsync(strUrl);
            }
            finally
            {
                client.Dispose();
            }

        }

        /// <summary>取得使用者檔案</summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        internal async static Task<UserProfile> GetUserProfileAsync(string ChannelAccessToken, string userid)
        {
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/profile/{0}", userid);
                var result = await client.GetStringAsync(strUrl);
                return JsonConvert.DeserializeObject<UserProfile>(result);

            }
            finally
            {
                client.Dispose();
            }

        }

        /// <summary>
        /// 取得群組或對話內指定成員的使用者檔案
        /// </summary>
        /// <param name="channelAccessToken"></param>
        /// <param name="userId"></param>
        /// <param name="groupIdorRoomId"></param>
        /// <returns></returns>
        internal async static Task<UserProfile> GetUserProfileAsync(string channelAccessToken, string userId, string groupIdorRoomId, SourceType type)
        {
            if (client == null) SetClient(channelAccessToken);
            try
            {

                string strUrl = string.Format("https://api.line.me/v2/bot/{0}/{1}/member/{2}", type.ToString(), groupIdorRoomId, userId);
                var result = await client.GetStringAsync(strUrl);
                return JsonConvert.DeserializeObject<UserProfile>(result);
            }
            finally
            {
                client.Dispose();
            }
        }
        /// <summary>離開群組或對話</summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        internal async static Task<bool> LeaveRoomorGroupAsync(string ChannelAccessToken, string id, SourceType type)
        {
            bool flag = false;
            if (client == null) SetClient(ChannelAccessToken);
            try
            {
                string strUrl = string.Format("https://api.line.me/v2/bot/{0}/{1}/leave", type.ToString(), id);
                var result = await client.PostAsync(strUrl, new StringContent(""));
                flag = result.IsSuccessStatusCode;
            }
            finally
            {
                client.Dispose();
            }
            return flag;

        }
        /// <summary>
        /// 根據傳入種類發送訊息
        /// </summary>
        /// <param name="ChannelAccessToken"></param>
        /// <param name="postMessageType"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal async static Task<bool> SendMessageActionAsync(string ChannelAccessToken, PostMessageType postMessageType, SendMessage message)
        {
            if (client == null) SetClient(ChannelAccessToken);

            try
            {
                string strUrl = string.Empty;
                switch (postMessageType)
                {
                    case PostMessageType.Reply:
                        strUrl = "https://api.line.me/v2/bot/message/reply";
                        break;

                    case PostMessageType.Push:
                        strUrl = "https://api.line.me/v2/bot/message/push";
                        break;

                    case PostMessageType.Multicast:
                        strUrl = "https://api.line.me/v2/bot/message/multicast";
                        break;
                }
                string sJson = JsonConvert.SerializeObject(message);
                var content = new StringContent(sJson, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(strUrl, content);
                if (result.IsSuccessStatusCode) return true;

                throw throwLineErrorMsg(result.Content.ReadAsStringAsync().Result);

            }
            finally
            {
                client.Dispose();
            }
        }

        #endregion

    }
}
