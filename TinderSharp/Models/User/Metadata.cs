using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Json;

namespace TinderSharp.Models.User
{
    [JsonConverter(typeof(ConventionBasedConverter<Metadata>))]
    public class Metadata
    {
        [JsonProperty("account")] public Account Account { get; internal set; }
        [JsonProperty("background_location.enabled")] public bool BackgroundLocation { get; internal set; }
        [JsonProperty("boost")] public Boost Boost { get; internal set; }        
        [JsonProperty("crm_inbox.enabled")]public bool crm_inbox { get; internal set; }
        [JsonProperty("fast_match")]public FastMatch FastMatch { get; internal set; }
        [JsonProperty("gold_homepage.enabled")] public bool HasGoldHomePage { get; internal set; }
        [JsonProperty("multi_photo.enabled")] public bool AreMultiphotoEnabled { get; internal set; }
        [JsonProperty("readreceipts.enabled")] public bool AreReadReceiptsEnabled { get; internal set; }
        [JsonProperty("top_picks")] public TopPicks TopPicks { get; internal set; }
        [JsonProperty("intro_pricing.enabled")]public bool intro_pricing { get; internal set; }
        [JsonProperty("recs.card_replay")]public bool CardReplay { get; internal set; }
        [JsonProperty("tinder_plus")]public TinderPlusMetadata TinderPlus { get; internal set; }
        [JsonProperty("super_like")]public SuperLike SuperLike { get; internal set; }
        [JsonProperty("profile")] public ProfileMetadata Profile { get; internal set; }
        [JsonProperty("select")]public Select Select { get; internal set; }
        [JsonProperty("places")]public PlacesMedatada Places { get; internal set; }
        public bool HasAcceptedTOS => !_TOS;
        [JsonProperty("swipe_surge")]public SwipeSurge SwipeSurge { get; internal set; }

        [JsonProperty("terms_of_service.needs_accept")] private bool _TOS { get; set; }

    }

    public class Account
    {
        [JsonProperty("email_prompt_required")] public bool EmailPromptRequired { get; internal set; }
        [JsonProperty("email_prompt_dismissible")] public bool EmailPromptDismissible { get; internal set; }
        [JsonProperty("email_prompt_show_marketing_opt_in")] public bool ShowMarketingOptIn { get; internal set; }
        [JsonProperty("email_prompt_show_strict_opt_in")] public bool ShowStrictOptIn { get; internal set; }
        [JsonProperty("fireboarding")] public bool Fireboarding { get; set; }

    }

    public class Boost
    {
        [JsonProperty("enabled")]public bool IsEnabled { get; internal set; }
        [JsonProperty("duration")] public long Duration { get; internal set; }
        [JsonProperty("intro_multiplier")] public long IntroMultiplier { get; internal set; }
        [JsonProperty("use_new_copy")] public bool UseNewCopy { get; internal set; }
    }


    public class FastMatch
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("preview_minimum_time")] public long PreviewMinimumTime { get; internal set; }
        [JsonProperty("notif_options")] public List<long> NotificationOptions { get; internal set; }
        [JsonProperty("notif_defaults")] public long NotificationDefaults { get; internal set; }
        [JsonProperty("new_count_fetch_interval")] public long NewCountFetchInterval { get; internal set; }
        [JsonProperty("boost_new_count_fetch_interval")] public long BoostNewCountFetchInterval { get; internal set; }
        [JsonProperty("new_count_threshold")] public long NewCountThreshold { get; internal set; }
        [JsonProperty("polling_mode")] public long PollingMode { get; internal set; }
        [JsonProperty("entry_point")] public bool EntryPoint { get; internal set; }
        [JsonProperty("use_teaser_endpoint")] public bool UseTeaserEndpoint { get; internal set; }
    }

    public class Select
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("recs_enabled")] public bool RecsEnabled { get; internal set; }
        [JsonProperty("invited")] public bool IsInvited { get; internal set; }
    }

    public class SuperLike
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("alc_mode")] public int Mode { get; internal set; }
    }


    public class TinderPlusMetadata
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("discount")] public bool HasDiscount { get; internal set; }
    }

    public class TopPicks
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("local_daily_enabled")] public bool LocalDailyEnabled { get; internal set; }
        [JsonProperty("local_daily_msg")] public string LocalDailyMessage { get; internal set; }
        [JsonProperty("free_daily")] public bool HasFreeDaily { get; internal set; }
        [JsonProperty("num_free_rated_limit")] public long NumFreeRatedLimit { get; internal set; }
        [JsonProperty("refresh_interval")] public long RefreshInterval { get; internal set; }
        [JsonProperty("Lookahead")] public long LookAhead { get; internal set; }
        [JsonProperty("post_swipe_paywall")] public bool PostSwipePaywall { get; internal set; }
    }


    public class ProfileMetadata
    {
        [JsonProperty("school_name_max_length")] public long SchoolNameMaxLenght { get; internal set; }
        [JsonProperty("job_title_max_length")] public long JobTitleMaxLenght { get; internal set; }
        [JsonProperty("company_name_max_length")] public long CompanyNameMaxLenght { get; internal set; }
        [JsonProperty("can_add_photos_from_facebook")] public bool CanAddPhotosFromFacebook { get; internal set; }
        [JsonProperty("can_edit_email")] public bool CanEditEmail { get; internal set; }
        [JsonProperty("can_edit_jobs")] public bool CanEditJobs { get; internal set; }
        [JsonProperty("can_edit_schools")] public bool CanEditSchools { get; internal set; }
        [JsonProperty("can_show_common_connections")] public bool ShowCommonConnections { get; internal set; }
    }

    public  class SwipeSurge
    {
        [JsonProperty("enabled")] public bool Enabled { get; internal set; }
        [JsonProperty("in_swipe_surge")] public bool IsActive { get; internal set; }
    }


    public class PlacesMedatada
    {
        [JsonProperty("available")] public bool Available { get; internal set; }
        [JsonProperty("places_ui")] public string PlacesUI { get; internal set; }
    }






  

}
