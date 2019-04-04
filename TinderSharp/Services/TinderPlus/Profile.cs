using System;
using TinderEndpoint;
using TinderSharp.Models.User;
using TinderSharp.Models.User.TinderPlus;

namespace TinderSharp.Services.TinderPlus
{
    public class Profile
    {
        public static TinderProfile HideAge(Guid token, bool hide)
        {
            Models.User.TinderPlus.HideAge showAge = new HideAge()
            {
                hide_age = hide
            };
            TinderProfile response = new RestMethods(TinderAPI.Profile, token).Post<TinderProfile>(showAge);

            return response;
        }

        public static TinderProfile HideDistance(Guid token, bool hide)
        {
            HideDistance hideDistace = new HideDistance()
            {
                hide_distance = hide
            };

            TinderProfile response = new RestMethods(TinderAPI.Profile, token).Post<TinderProfile>(hideDistace);

            return response;
        }

        public static TinderProfile HideAds(Guid token, bool hide)
        {
            HideAds obj = new HideAds()
            {
                hide_ads = hide
            };

            TinderProfile response = new RestMethods(TinderAPI.Profile, token).Post<TinderProfile>( obj);

            return response;
        }
    }
}
