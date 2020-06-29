using System;
using System.Linq;
using System.Text.RegularExpressions;
using TinderEndpoint;
using TinderSharp.Models;
using TinderSharp.Models.User;

namespace TinderSharp.Services.Messages
{
    public static class Messages
    {
        public static Message SendMessage(this TinderClient client, string matchId, string msg)
        {
            var url = TinderAPI.Message.Replace("{MatchId}", matchId);

            var response = new RestMethods(url, client.XAuthToken).Post<Message>(new {message = msg});

            return response;
        }

        public static Message SendGifMessage(this TinderClient client, string matchId, Uri GiphyLink)
        {
            var url = TinderAPI.Message.Replace("{MatchId}", matchId);
            var regex = Regex.Match(GiphyLink.AbsoluteUri, @"https:\/\/media1\.giphy\.com\/media\/(.+)\/giphy\.gif");
            string gifId = regex.Groups[1].Value;
            var response =
                new RestMethods(url, client.XAuthToken).Post<Message>(new
                    {message = GiphyLink, gif_id = gifId, type = "gif"});

            return response;
        }

        public static Message SendSongMessage(this TinderClient client, string matchId, ISongMessage song)
        {
            var url = TinderAPI.Message.Replace("{MatchId}", matchId);
            var response =
                new RestMethods(url, client.XAuthToken).Post<Message>(new
                    {message = song.GetUri(), track_id = song.GetSongId(), type = "song"});

            return response;

        }

        public static MessagePage GetMessages(this TinderClient client, string matchId, UrlQuery query = null)
        {
            string url = TinderAPI.Message.Replace("{MatchId}", matchId);

            if (query != null)
                url += query.Generate();

            var response = new RestMethods(url, client.XAuthToken).Get<MessagePage>();
            return response;
        }

        public static void MarkMessageAsSeen(this TinderClient client, string matchId, string messageId)
        {
            string url = TinderAPI.SeenMessage
                .Replace("{MatchId}", matchId)
                .Replace("{MessageId}", messageId);

            new RestMethods(url, client.XAuthToken).Post();
        }




        public static UrlQueryBuilder AddMessagePageCount(this UrlQueryBuilder builder, int count)
        {
            builder.Add("count",count.ToString());
            return builder;
        }

        public static UrlQueryBuilder AddMessagePageToken(this UrlQueryBuilder builder, string pageToken)
        {
            builder.Add("page_token",pageToken);
            return builder;
        }
        
    }
}