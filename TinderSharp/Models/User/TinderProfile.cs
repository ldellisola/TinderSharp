using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Models.Images;

namespace TinderSharp.Models.User
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>Boost, contact_cards, plus_control,travel, tinderUniversity, super_likes,products,instagram, purchases, EmailSettings, read_recipts, swipe_note, tutorials not implemented</remarks>
    public class Profile
    {
        [JsonProperty("likes")] public LikesData Likes { get; set; }
        [JsonProperty("user")] public UserData User { get; set; }
        [JsonProperty("account")] public AccountData Account { get; set; }

        // likes
        public class LikesData
        {
            public int Likes_remaining { get; set; }
        }
        // user
        public class UserData
        {
            [JsonProperty("_id")] public string Id { get; set; }
            [JsonProperty("age_filter_max")] public long AgeFilterMax { get; set; }
            [JsonProperty("age_filter_min")] public long AgeFilterMin { get; set; }
            [JsonProperty("bio")] public string Biography { get; set; }
            [JsonProperty("birth_date")] public DateTimeOffset BirthDate { get; set; }
            [JsonProperty("create_date")] public DateTimeOffset CreationDate { get; set; }
            [JsonProperty("discoverable")] public bool IsDiscoverable { get; set; }
            [JsonProperty("crm_id")] public string CRM { get; set; }
            [JsonProperty("interests")] public List<Interest> FacebookInterests { get; set; }
            [JsonProperty("distance_filter")] public int DistanceFilter { get; set; }
            [JsonProperty("gender")] public Gender Gender { get; set; }
            [JsonProperty("gender_filter")] public Gender GenderFilter { get; set; }
            [JsonProperty("name")] public string Name { get; set; }
            [JsonProperty("photos")] public List<Photo> Photos { get; set; }
            [JsonProperty("photos_processing")] public bool PhotosProcessing { get; set; }
            [JsonProperty("photo_optimizer_enabled")] public bool PhotoOptimizerEnabled { get; set; }
            [JsonProperty("photo_optimizer_has_result")] public bool PhotoOptimizerHasResult { get; set; }
            [JsonProperty("ping_time")] public DateTimeOffset PingTime { get; set; }
            [JsonProperty("jobs")] public List<Job> Jobs { get; set; }
            [JsonProperty("schools")] public List<HideableField> Schools { get; set; }
            [JsonProperty("badges")] public List<Badge> Badges { get; set; }
            [JsonProperty("username")] public string Username { get; set; }
            [JsonProperty("phone_id")] public string PhoneNumber { get; set; }
            [JsonProperty("interested_in")] public List<Gender> InterestedGenders { get; set; }
            [JsonProperty("pos")] public Coordinates Position { get; set; }
            [JsonProperty("top_picks_discoverable")] public bool TopPicksDiscoverable { get; set; }
            [JsonProperty("photo_tagging_enabled")] public bool PhotoTaggingEnabled { get; set; }
            [JsonProperty("city")] public City CurrentCity { get; set; }
            [JsonProperty("user_interests")] public UserInterest UserInterests{ get; set; }
            [JsonProperty("recommended_sort_discoverable")] public bool RecommendedSortDiscoverable { get; set; }
            [JsonProperty("selfie_verification")] public string SelfieVerification { get; set; }
            [JsonProperty("noonlight_protected")] public bool NoonlightProtected { get; set; }
            [JsonProperty("sync_swipe_enabled")] public bool SyncSwipeEnabled { get; set; }

            public class Interest
            {
                public string Id { get; set; }
                public string Name { get; set; }
            }

            public class Badge
            {
                [JsonProperty("type")] public string Type { get; set; }
            }

            public class Coordinates
            {
                [JsonProperty("lat")] public double Latitude { get; set; }
                [JsonProperty("lon")] public double Longitude { get; set; }
            }

            public class City
            {
                [JsonProperty("name")] public string  Name { get; set; }
                [JsonProperty("region")] public string Region { get; set; }
            }

            public class UserInterest
            {
                [JsonProperty("selected_interests")] public List<Interest> Selected { get; set; }
                [JsonProperty("available_interests")] public List<Interest> Available { get; set; }

                [JsonProperty("min_interests")] public int MinSelection { get; set; }
                [JsonProperty("max_interests")] public int MaxSelection { get; set; }
            }

        }
        // account
        public class AccountData
        {
            [JsonProperty("account_email")] public string Email { get; set; }
            [JsonProperty("account_phone_number")] public string PhoneNumber { get; set; }  
            [JsonProperty("apple_id_linked")] public bool UsesAppleID { get; set; }
            [JsonProperty("facebook_id_linked")] public bool UsesFacebookID { get; set; }
            [JsonProperty("is_email_verified")] public bool IsEmailVerified { get; set; }
            [JsonProperty("username")] public string Username { get; set; }
        }

    }

    public partial class EmailSettings
    {
        public bool new_matches { get; set; }
        public bool messages { get; set; }
        public bool promotions { get; set; }
    }

    

    public partial class PositionInfo
    {
        public State State { get; set; }
        public Country Country { get; set; }
    }

    public partial class State
    {
        public string Name { get; set; }
        public Bounds Bounds { get; set; }
    }

    public partial class Country
    {
        public string Name { get; set; }
        public string Cc { get; set; }
        public Bounds Bounds { get; set; }
    }

    public partial class Bounds
    {
        public Coordinates Ne { get; set; }
        public Coordinates Sw { get; set; }
    }

    public partial class Coordinates
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

}
