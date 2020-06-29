using System;
using ExtensionMethods;
using TinderEndpoint;
using TinderSharp.Models.User;

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
    public static class User
    {
        public static MetadataV2 GetMetadata(this TinderClient tinderClient)
        {
            var response = new RestMethods(TinderAPI.MetadataV2, tinderClient.XAuthToken).Get<MetadataV2>();

            return response;
        }

        public static TinderSharp.Models.User.Profile GetProfile(this TinderClient tinderClient)
        {
            var response = new RestMethods(TinderAPI.Profile,
                tinderClient.XAuthToken).Get<TinderSharp.Models.User.Profile>();

            return response;
        }

        public static void ChangeUsername(this TinderClient client, string newUsername)
        { 
            new RestMethods(TinderAPI.Username, client.XAuthToken).Put( new { username = newUsername });
        }
        public static void ResetUsername(this TinderClient client)
        {
            new RestMethods(TinderAPI.Username, client.XAuthToken).Delete();
        }
        
        public static Update GetUpdates(this TinderClient client, DateTime updatedFrom = default(DateTime))
        {
            var obj = new
            {
                nudge = true,
                last_activity_date = updatedFrom.ToTinderString()
            };
            var response = new RestMethods(TinderAPI.Updates, client.XAuthToken).Post<Update>(obj);
        
            return response;
        }

    }
}
