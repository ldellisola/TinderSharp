using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TinderSharp.Models;

namespace TinderSharp.Services.Messages
{
    public static class Messages
    {
        private const string Message = @"/user/matches/{MatchId}";
        private const string SeenMessage = @"/v2/seen/{MatchId}/{MessageId}";
        public static async Task<Message> SendMessage(this TinderClient client, string matchId, string msg)
        {
            var url = Message.Replace("{MatchId}", matchId);

            var response = await new RestClient(url, client.XAuthToken).Post<Message>(new { message = msg });

            return response;
        }

        public static async Task<Message> SendGifMessage(this TinderClient client, string matchId, Uri GiphyLink)
        {
            var url = Message.Replace("{MatchId}", matchId);
            var regex = Regex.Match(GiphyLink.AbsoluteUri, @"https:\/\/media1\.giphy\.com\/media\/(.+)\/giphy\.gif");
            string gifId = regex.Groups[1].Value;
            var response = await new RestClient(url, client.XAuthToken).Post<Message>(
                new { message = GiphyLink, gif_id = gifId, type = "gif" });

            return response;
        }

        public static async Task<Message> SendSongMessage(this TinderClient client, string matchId, ISongMessage song)
        {
            var url = Message.Replace("{MatchId}", matchId);
            var response = await new RestClient(url, client.XAuthToken).Post<Message>(
                new { message = song.GetUri(), track_id = song.GetSongId(), type = "song" });

            return response;

        }

        public static async Task<MessagePage> GetMessages(this TinderClient client, string matchId, UrlQuery query = null)
        {
            string url = Message.Replace("{MatchId}", matchId);

            if (query != null)
                url += query.Generate();

            var response = await new RestClient(url, client.XAuthToken).Get<MessagePage>();
            return response;
        }

        public static async Task MarkMessageAsSeen(this TinderClient client, string matchId, string messageId)
        {
            string url = SeenMessage
                .Replace("{MatchId}", matchId)
                .Replace("{MessageId}", messageId);

            await new RestClient(url, client.XAuthToken).Post();
        }




        public static UrlQueryBuilder AddMessagePageCount(this UrlQueryBuilder builder, int count)
        {
            builder.Add("count", count.ToString());
            return builder;
        }

        public static UrlQueryBuilder AddMessagePageToken(this UrlQueryBuilder builder, string pageToken)
        {
            builder.Add("page_token", pageToken);
            return builder;
        }

    }
}