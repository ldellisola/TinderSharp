
using System;
using System.Threading.Tasks;
using TinderSharp.Extensions;
using TinderSharp.Models;
using TinderSharp.Models.User;



namespace TinderSharp.Services
{
    public static class User
    {
        private const string UpdatesEndpoint = @"/updates";
        private const string UsernameEndpoint = @"/profile/username";
        private const string ProfileEndpoint = @"/v2/profile?include=likes,user,account";
        private const string MetadataEndpoint = @"/v2/meta";

        public static async Task<Metadata> GetMetadata(this TinderClient tinderClient)
        {
            var response = await new RestClient(MetadataEndpoint, tinderClient.XAuthToken).Get<Metadata>();

            return response;
        }

        public static async Task<Profile> GetProfile(this TinderClient tinderClient)
        {
            var response = await new RestClient(ProfileEndpoint, tinderClient.XAuthToken).Get<Profile>();

            return response;
        }

        public static async Task ChangeUsername(this TinderClient client, string newUsername)
        {
            await new RestClient(UsernameEndpoint, client.XAuthToken).Put(new { username = newUsername });
        }
        public static async Task ResetUsername(this TinderClient client)
        {
            await new RestClient(UsernameEndpoint, client.XAuthToken).Delete();
        }

        public static async Task<Update> GetUpdates(this TinderClient client, DateTime updatedFrom = default(DateTime))
        {
            var obj = new
            {
                nudge = true,
                last_activity_date = updatedFrom.ToTinderString()
            };
            var response = await new RestClient(UpdatesEndpoint, client.XAuthToken).Post<Update>(obj);

            return response;
        }

        public static async Task<Profile> ChangeSearchPreferences(this TinderClient client, SearchPreferences pref)
        {
            var url = ProfileEndpoint;
            var response = await new RestClient(url, client.XAuthToken).Post<Profile>(new
            {
                user = pref
            });
            return response;
        }
    }
}
