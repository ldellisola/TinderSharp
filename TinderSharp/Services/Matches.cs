using System;
using System.Collections.Generic;
using TinderEndpoint;
using TinderSharp.Models.User;

namespace TinderSharp.Services
{
    public static class Matches
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static IList<RecommendedMatch> GetMatchRecommendations(this TinderClient client)
        {
            var response = new RestMethods(TinderAPI.MatchRecommendations, client.XAuthToken).Get<RecommendedMatches>();
        
            return response.Results;
        }

        public static MatchResponse Like(this TinderClient client,string userId)
        {
            var url = TinderAPI.Like.Replace("{_id}", userId);
            var response = new RestMethods(url, client.XAuthToken).Post<MatchResponse>();
        
            return response;
        }
        public static void Pass(this TinderClient client,string userId)
        {
            var url = TinderAPI.Pass.Replace("{_id}", userId);
            new RestMethods(url, client.XAuthToken).Post();
        }
        public static MatchResponse SuperLike(this TinderClient client,string userId)
        {
            var url = TinderAPI.SuperLike.Replace("{_id}", userId);
            var response = new RestMethods(url,client.XAuthToken).Post<MatchResponse>();

            return response;
        }
        public static void Unmatch(this TinderClient client,string matchID)
        {
            var url = TinderAPI.Unmatch.Replace("{match_id}", matchID);
            var response = new RestMethods(url, client.XAuthToken).Delete();
        
        }
    }
}