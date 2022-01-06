using Newtonsoft.Json;
using RestSharp;
using System;

namespace Iotsys.Ezviz
{
    public class Ys7Client
    {
        private const string appKey = "";

        private const string appSecret = "";

        public static AccessTokenResponseData TokenData = null;

        private Ys7Client()
        {
            TokenData = ReadAccsessToken();
            if (TokenData == null)
            {
                //不存在则更新
                TokenData = UpdateAccessToken();
            }
        }

        /// <summary>
        /// 更新accessToken
        /// </summary>
        public static AccessTokenResponseData UpdateAccessToken()
        {
            var tokenData = GetAccessToken().Data;
            UpdateAccessToken(tokenData);

            return tokenData;
        }

        public static AccessTokenResponseData ReadAccsessToken()
        {
            //var token = Repository.Setting.Get("ys_accessToken");
            //if (token != null)
            //{
            //    return JsonConvert.DeserializeObject<AccessTokenResponseData>(token.Value);
            //}

            return null;
        }

        public static void UpdateAccessToken(AccessTokenResponseData token)
        {
            //Repository.Setting.Update("ys_accessToken", JsonConvert.SerializeObject(accessTokenData));
        }

        /// <summary>
        /// 检查accessToken时效，使用3天换新的
        /// </summary>
        /// <param name="force"></param>
        public static void CheckAccessTokenExpire(bool force = false)
        {
            var exp = GetYsDateTime(TokenData.ExpireTime);

            if (exp.AddDays(-3) < DateTime.Now)
            {
                UpdateAccessToken();
            }
        }

        /// <summary>
        /// 获取 accessToken 
        /// </summary>
        /// <returns></returns>
        public static AccessTokenResponse GetAccessToken()
        {
            var client = new RestClient("https://open.ys7.com/api/lapp/token/get");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("appKey", appKey);
            request.AddParameter("appSecret", appSecret);

            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<AccessTokenResponse>(response.Content);
        }

        /// <summary>
        /// 获取萤石API相关的RestClient对象
        /// </summary>
        /// <returns></returns>
        public static RestClient GetClient(bool addDefault = true)
        {
            CheckAccessTokenExpire();

            var client = new RestClient("https://open.ys7.com/api/lapp/");
            if (addDefault)
            {
                client.AddDefaultQueryParameter("accessToken", TokenData.AccessToken);
                client.AddDefaultHeader("Content-Type", "application/x-www-form-urlencoded");
            }

            return client;
        }

        /// <summary>
        /// timestamp转datetime 毫秒单位
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime GetYsDateTime(long timeStamp)
        {
            DateTime dtStart = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            TimeSpan toNow = new TimeSpan(timeStamp * 10000);
            return dtStart.Add(toNow);
        }
    }
}
