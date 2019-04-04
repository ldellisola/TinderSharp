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
            var response = new RestMethods(token).Get<RecommendedMatches>(TinderAPI.MatchRecommendations);


            return response;
        }

        public static bool ResetUsername(Guid token)
        {
            var response = new RestMethods(token).Delete(TinderAPI.Username);

            return response == "";
        }

        public static bool ChangeUsername(Guid token, string newUsername)
        {
            var response = new RestMethods(token).Put(TinderAPI.Username, new Username() { username = newUsername });
            return response == "";

        }

        public static string GetMetadata(Guid token)
        {
            var response = new RestMethods(token).Get(TinderAPI.Metadata);

            return response;
        }

        public static string GetMetadataV2(Guid token)
        {
            var response = new RestMethods(token).Get(TinderAPI.MetadataV2);

            return response;
        }

        // Todo lo que esta abajo de esto no fue probado.

        public static void GetUpdates(Guid token, DateTime initialDate = default(DateTime))
        {
            LastActivityDate obj = new LastActivityDate()
            {
                last_activity_date = (initialDate != default(DateTime)) ? initialDate.ToTinderString() : ""
            };

            var response = new RestMethods(token).Post(TinderAPI.Updates, obj,token);

            int a = 0;
            a++;
        }

        public static bool Like(Guid token,string idToLike)
        {
            var response = new RestMethods(token).Get(TinderAPI.Like.Replace("{_id}",idToLike));

            return true;
        }
        public static bool Pass(Guid token,string idToPass)
        {
            var response = new RestMethods(token).Get(TinderAPI.Pass.Replace("{_id}", idToPass));

            return true;
        }
        public static bool SuperLike(Guid token,string idToSuperLike)
        {
            var response = new RestMethods(token).Post(TinderAPI.SuperLike.Replace("{_id}", idToSuperLike),string.Empty);

            return true;
        }

        //public static void ChangeLocation(Guid token,double Lat, double lon)
        //{

        //}



        public static void MessageMatch(Guid token,string otherUserID, string msg)
        {
            Message content = new Message() { message = msg };
            var response = new RestMethods(token).Post(TinderAPI.Message.Replace("{id}", otherUserID), content);

            int a = 0;
            a++;

        }

        // TO BE TESTED
        public static void MessageMatch(Guid token,string otherUserID, Message msg)
        {

            var response = new RestMethods(token).Post(TinderAPI.Message.Replace("{id}", otherUserID), msg);

        }

        public static void Unmatch(Guid token,string matchID)
        {
            var response = new RestMethods(token).Delete(TinderAPI.Message.Replace("{match_id}", matchID));

        }
    }
}
