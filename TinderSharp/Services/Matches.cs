using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TinderSharp.Models;
using TinderSharp.Models.Matches;

namespace TinderSharp.Services
{
    public static class Matches
    {
        private const string CurrentMatchesEndpoint = @"/v2/matches";
        private const string MatchRecommendationsEndpoint = @"/v2/recs/core";
        private const string LikeEndpoint = @"/like/{UserId}";
        private const string PassEndpoint = @"/pass/{UserId}";
        private const string SuperLikeEndpoint = @"/like/{UserId}/Super";
        private const string UnmatchEndpoint = @"/user/matches/{MatchId}";
        private const string UserEndpoint = @"/user/{UserId}";


        public static async Task<IList<RecommendedMatch>> GetMatchRecommendations(this TinderClient client)
        {
            var response = await new RestClient(MatchRecommendationsEndpoint, client.XAuthToken).Get<RecommendedMatches>();
            return response.Results;
        }

        public static async Task<MatchResponse> Like(this TinderClient client, string userId)
        {
            var url = LikeEndpoint.Replace("{UserId}", userId);
            var response = await new RestClient(url, client.XAuthToken).Post<MatchResponse>();

            return response;
        }
        public static async Task Pass(this TinderClient client, string userId)
        {
            var url = PassEndpoint.Replace("{UserId}", userId);
            await new RestClient(url, client.XAuthToken).Post();
        }
        public static async Task<MatchResponse> SuperLike(this TinderClient client, string userId)
        {
            var url = SuperLikeEndpoint.Replace("{UserId}", userId);
            var response = await new RestClient(url, client.XAuthToken).Post<MatchResponse>();

            return response;
        }
        public static async Task Unmatch(this TinderClient client, string matchID)
        {
            var url = UnmatchEndpoint.Replace("{MatchId}", matchID);
            await new RestClient(url, client.XAuthToken).Delete();
        }

        public static async Task<IList<MatchResponse.Match>> GetMatches(this TinderClient client, UrlQuery query)
        {
            query.Add("message", "0");

            var url = CurrentMatchesEndpoint + query.Generate();

            var response = await new RestClient(url, client.XAuthToken).Get<MatchesWrapper>();

            return response.Matches;
        }

        public static async Task<IList<MatchResponse.Match>> GetMessagedMatches(this TinderClient client, UrlQuery query)
        {
            query.Add("message", "1");
            var url = CurrentMatchesEndpoint + query.Generate();

            var response =await new RestClient(url, client.XAuthToken).Get<MatchesWrapper>();

            return response.Matches;
        }

        public static async Task<MatchedPerson> GetMatchProfile(this TinderClient client, string userId)
        {
            var url = UserEndpoint.Replace("{UserId}", userId);

            var response = await new RestClient(url, client.XAuthToken).Get<MatchedPerson>();

            return response;

        }



        public static UrlQueryBuilder AddMatchesCount(this UrlQueryBuilder builder, int count)
        {
            builder.Add("count", count.ToString());
            return builder;
        }

        private class MatchesWrapper
        {
            [JsonProperty("matches")] public IList<MatchResponse.Match> Matches { get; set; }
        }
    }
}