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
            TinderProfile response = new RestMethods(token).Post<TinderProfile>(TinderAPI.Profile, showAge);

            return response;
        }

        public static TinderProfile HideDistance(Guid token, bool hide)
        {
            HideDistance hideDistace = new HideDistance()
            {
                hide_distance = hide
            };

            TinderProfile response = new RestMethods(token).Post<TinderProfile>(TinderAPI.Profile, hideDistace);

            return response;
        }

        public static TinderProfile HideAds(Guid token, bool hide)
        {
            HideAds obj = new HideAds()
            {
                hide_ads = hide
            };

            TinderProfile response = new RestMethods(token).Post<TinderProfile>(TinderAPI.Profile, obj);

            return response;
        }
    }
}
