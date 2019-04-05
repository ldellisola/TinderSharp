using System;
using System.Collections.Generic;
using System.Text;
using TinderSharp.Models.User;
using TinderEndpoint;

namespace TinderSharp.Services
{
    public class Profile
    {

        public static TinderProfile GetOwnProfile(Guid token)
        {
            var response = new RestMethods(TinderAPI.Profile,token).Get<TinderProfile>();

            return response;
        }

        public static TinderProfile UpdateSearchPreferences(Guid token, Gender gender, int minAge, int maxAge, int radius)
        {
            SearchPreferences pref = new SearchPreferences()
            {
                age_filter_max = maxAge,
                age_filter_min = minAge,
                distance_filter = radius,
                Gender = (int)gender
            };

            if (pref.Validate())
            {
                return UpdateSearchPreferences(token, pref);
            }
            else
                return null;
        }

        public static TinderProfile UpdateSearchPreferences(Guid token, SearchPreferences pref)
        {

            var response = new RestMethods(TinderAPI.Profile, token).Post<TinderProfile>(pref);

            return response;
        }

    }
}
