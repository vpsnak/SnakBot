using System;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TwitchLib.Models.API;
using System.IO;
using System.Net;

namespace SnakBot
{
    public class ApiRequest
    {
        private static string clientID = null;
        private static string accessToken = null;
        private static void setClientID(string clientID)
        {
            ApiRequest.clientID = clientID;
        }
        private static void setAccessToken(string accessToken)
        {
            ApiRequest.accessToken = accessToken;
        }
        public ApiRequest(string clientID, string accessToken)
        {
            setClientID(clientID);
            setAccessToken(accessToken);
        }
        /// <summary>
        /// Update the <paramref name="status"/> and <paramref name="game"/> of a <paramref name="channel"/>.
        /// </summary>
        /// <param name="status">Channel's title.</param>
        /// <param name="game">Game category to be classified as.</param>
        /// <param name="channel">The channel to update.</param>
        /// <param name="accessToken">An oauth token with the required scope.</param>
        /// <returns>The response of the request.</returns>
        public static async Task<Channel> UpdateStreamDashboard(string status, string game, string lang, string broadcaster_lang, string channel)
        {
               var data = "{\"channel\":{\"status\":\"" + status + "\",\"game\":\"" + game + "\",\"broadcaster_language\":\"" + lang + "\",\"broadcaster_language_enabled\":\"" + broadcaster_lang + "\"}}";
            return new Channel(JObject.Parse(await MakeRestRequest($"https://api.twitch.tv/kraken/channels/{channel}", "PUT", data)));
        }
        private static async Task<string> MakeRestRequest(string url, string method, string requestData = null)
        {
            if (string.IsNullOrWhiteSpace(clientID) && string.IsNullOrWhiteSpace(accessToken))
                throw new InvalidCredentialException("All API calls require Client-Id or OAuth token.");

            var data = new UTF8Encoding().GetBytes(requestData ?? "");
            //accessToken = accessToken?.ToLower().Replace("oauth:", "");

            var request = (HttpWebRequest)WebRequest.Create(new Uri($"{url}?client_id={clientID}"));
            request.Method = method;
            request.Accept = "application/vnd.twitchtv.v3+json";
            request.ContentType = method == "POST"
                ? "application/x-www-form-urlencoded"
                : "application/json";
            request.Headers.Add("Client-ID", clientID);

            if (!string.IsNullOrWhiteSpace(accessToken))
                request.Headers.Add("Authorization", $"OAuth {accessToken}");
            else if (!string.IsNullOrWhiteSpace(accessToken))
                request.Headers.Add("Authorization", $"OAuth {accessToken}");

            using (var requestStream = await request.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(data, 0, data.Length);
            }

            try
            {
                using (var responseStream = await request.GetResponseAsync())
                {
                    return await new StreamReader(responseStream.GetResponseStream(), Encoding.Default, true).ReadToEndAsync();
                }
            }
            catch (WebException e) { handleWebException(e); return null; }

        }
        private static void handleWebException(WebException e)
        {
            HttpWebResponse errorResp = e.Response as HttpWebResponse;
            switch (errorResp.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new BadScopeException("Your request was blocked due to bad credentials (do you have the right scope for your access token?).");
                case HttpStatusCode.NotFound:
                    throw new BadResourceException("The resource you tried to access was not valid.");
                default:
                    throw e;
            }
        }
    }
    /// <summary>Exception representing a detection that sent credentials were invalid.</summary>
    public class InvalidCredentialException : Exception
    {
        /// <summary>Exception constructor</summary>
        public InvalidCredentialException(string data)
            : base(data)
        {
        }
    }
    /// <summary>Exception representing a provided scope was not permitted.</summary>
    public class BadScopeException : Exception
    {
        /// <summary>Exception constructor</summary>
        public BadScopeException(string data)
            : base(data)
        {
        }
    }
    /// <summary>Exception representing an invalid resource</summary>
    public class BadResourceException : Exception
    {
        /// <summary>Exception constructor</summary>
        public BadResourceException(string apiData)
            : base(apiData)
        {
        }
    }
}
