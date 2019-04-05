using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TinderEndpoint;
using TinderSharp.Models.User;
using ExtensionMethods;

namespace ExtensionMethods
{
    public static class DateTimeExtension
    {
        public static string ToTinderString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }
    }
}

namespace TinderSharp.Services
{
    public class User
    {
        public static RecommendedMatches GetMatchRecommendations(Guid token)
        {
            var response = new RestMethods(TinderAPI.MatchRecommendations, token).Get<RecommendedMatches>();

            return response;
        }

        public static bool ResetUsername(Guid token)
        {
            var response = new RestMethods(TinderAPI.Username, token).Delete();

            return response == "";
        }

        public static bool ChangeUsername(Guid token, string newUsername)
        {
            var response = new RestMethods(TinderAPI.Username, token).Put( new Username() { username = newUsername });
            return response == "";

        }

        public static Metadata GetMetadata(Guid token)
        {
            var response = new RestMethods(TinderAPI.Metadata, token).Get<Metadata>();

            return response;
        }

        public static MetadataV2 GetMetadataV2(Guid token)
        {
            var response = new RestMethods(TinderAPI.MetadataV2, token).Get<MetadataV2Container>();

            return response.Data;
        }


        public static Update GetUpdates(Guid token, DateTime initialDate = default(DateTime))
        {
            LastActivityDate obj = new LastActivityDate()
            {
                last_activity_date = (initialDate != default(DateTime)) ? initialDate.ToTinderString() : ""
            };

            var response = new RestMethods(TinderAPI.Updates, token).Post<Update>(obj);

            return response;
        }

        public static bool Like(Guid token,string idToLike)
        {
            var response = new RestMethods(TinderAPI.Like.Replace("{_id}", idToLike), token).Get();

            return true;
        }
        public static bool Pass(Guid token,string idToPass)
        {
            var response = new RestMethods(TinderAPI.Pass.Replace("{_id}", idToPass), token).Get();

            return true;
        }
        public static bool SuperLike(Guid token,string idToSuperLike)
        {
            var response = new RestMethods(TinderAPI.SuperLike.Replace("{_id}", idToSuperLike),  token).Post(string.Empty);

            return true;
        }

        //public static void ChangeLocation(Guid token,double Lat, double lon)
        //{

        //}



        public static void MessageMatch(Guid token,string otherUserID, string msg)
        {
            Message content = new Message() { message = msg };
            var response = new RestMethods(TinderAPI.Message.Replace("{id}", otherUserID), token).Post( content);

            int a = 0;
            a++;

        }

        // TO BE TESTED
        public static void MessageMatch(Guid token,string otherUserID, Message msg)
        {

            var response = new RestMethods(TinderAPI.Message.Replace("{id}", otherUserID), token).Post( msg);

        }

        public static void Unmatch(Guid token,string matchID)
        {
            var response = new RestMethods(TinderAPI.Message.Replace("{match_id}", matchID), token).Delete();

        }
    }
}
