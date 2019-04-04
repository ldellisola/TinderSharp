using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{
    public partial class Metadata
    {
        public long Status { get; set; }
        public Account Account { get; set; }
        public ClientResources client_resources { get; set; }
        public List<object> Notifications { get; set; }
        public List<object> Groups { get; set; }
        public Rating Rating { get; set; }
        public Travel Travel { get; set; }
        public List<object> Purchases { get; set; }
        public Versions Versions { get; set; }
        public MetadataGlobals Globals { get; set; }
        public List<string> Tutorials { get; set; }
        public Places Places { get; set; }
        public Products Products { get; set; }
        public UserMetadata User { get; set; }
    }




    public partial class RateCard
    {
        public List<Carousel> carousel { get; set; }
    }

    public partial class Carousel
    {
        public string slug { get; set; }
    }

    public partial class MetadataGlobals
    {
        public long boost_intro_multiplier { get; set; }
        public long ad_swipe_interval { get; set; }
        public bool rate_app { get; set; }
        public bool app_boy { get; set; }
        public long super_like_alc_mode { get; set; }
        public bool super_like { get; set; }
        public bool recs_blend { get; set; }
        public CreditCard credit_card { get; set; }
        public bool squads_enabled { get; set; }
        public long squads_extension_length { get; set; }
        public long squads_expiration_notice { get; set; }
        public bool photo_preview_enabled { get; set; }
        public bool discount { get; set; }
        public bool crm_inbox_enabled { get; set; }
        public bool boost { get; set; }
        public long boost_duration { get; set; }
        public bool fast_match { get; set; }
        public long fast_match_preview_minimum_time { get; set; }
        public List<long> fast_match_notif_options { get; set; }
        public long fast_match_notif_default { get; set; }
        public long fast_match_new_count_fetch_interval { get; set; }
        public long fast_match_boost_new_count_fetch_interval { get; set; }
        public long fast_match_new_count_threshold { get; set; }
        public long fast_match_polling_mode { get; set; }
        public bool fast_match_entry_point { get; set; }
        public bool fast_match_use_teaser_endpoint { get; set; }
        public bool top_picks { get; set; }
        public bool top_picks_local_daily_enabled { get; set; }
        public string top_picks_local_daily_msg { get; set; }
        public TopPicksLocalDailyOffsets top_picks_local_daily_offsets { get; set; }
        public bool top_picks_free_daily { get; set; }
        public long top_picks_num_free_rated_limit { get; set; }
        public long top_picks_refresh_interval { get; set; }
        public long top_picks_lookahead { get; set; }
        public bool top_picks_post_swipe_paywall { get; set; }
        public bool intro_pricing { get; set; }
        public bool paywall_full_price { get; set; }
        public bool paywall_e1 { get; set; }
        public bool paywall_e2 { get; set; }
        public bool paywall_bouncer_avatar { get; set; }
        public long paywall_e3 { get; set; }
        public long paywall_e4 { get; set; }
        public bool merchandising_gold_v1_enabled { get; set; }
        public bool merchandising_gold_v2_enabled { get; set; }
        public bool can_edit_jobs { get; set; }
        public bool can_edit_schools { get; set; }
        public bool can_edit_email { get; set; }
        public bool can_add_photos_from_facebook { get; set; }
        public bool can_show_common_connections { get; set; }
        public bool web_payments_enabled { get; set; }
        public bool card_replay { get; set; }
        public TypingIndicator typing_indicator { get; set; }
        public ProfileMetadata Profile { get; set; }
        public bool email_prompt_required { get; set; }
        public bool email_prompt_dismissible { get; set; }
        public bool email_prompt_show_marketing_opt_in { get; set; }
        public bool email_prompt_show_strict_opt_in { get; set; }
        public SwipeSurge swipe_surge { get; set; }
    }

    public partial class CreditCard
    {
        public long variant { get; set; }
        public bool price_tos_on_top { get; set; }
    }

    public partial class ProfileMetadata
    {
        public long school_name_max_length { get; set; }
        public long job_title_max_length { get; set; }
        public long _company_name_max_length { get; set; }
    }

    public partial class SwipeSurge
    {
        public bool Enabled { get; set; }
        public bool in_swipe_surge { get; set; }
    }

    public partial class TopPicksLocalDailyOffsets
    {
        public long Offset0 { get; set; }
        public long Offset1 { get; set; }
        public long Offset2 { get; set; }
        public long Offset3 { get; set; }
    }

    public partial class TypingIndicator
    {
        public long typing_heartbeat { get; set; }
        public long typing_ttl { get; set; }
    }

    public partial class Places
    {
        public bool available { get; set; }
        public string places_ui { get; set; }
    }

    public partial class Products
    {
        public Boost Superlike { get; set; }
        public Boost Boost { get; set; }
    }

    public partial class Boost
    {
        public Regular Regular { get; set; }
    }

    public partial class Regular
    {
        public List<Skus> Skus { get; set; }
    }

    public partial class Skus
    {
        public string product_type { get; set; }
        public string purchase_type { get; set; }
        public string product_id { get; set; }
        public long Amount { get; set; }
        public bool? is_primary { get; set; }
        public bool? is_base_group { get; set; }
    }

    public partial class Rating
    {
        public long likes_remaining { get; set; }
        public SuperLikes super_likes { get; set; }
    }

    public partial class SuperLikes
    {
        public long remaining { get; set; }
        public long alc_remaining { get; set; }
        public long new_alc_remaining { get; set; }
        public long allotment { get; set; }
        public long superlike_refresh_amount { get; set; }
        public long superlike_refresh_interval { get; set; }
        public string superlike_refresh_rnterval_unit { get; set; }
        public object resets_at { get; set; }
    }

    public partial class Travel
    {
        public bool is_traveling { get; set; }
    }

    public partial class UserMetadata: User
    {
        public bool top_picks_discoverable { get; set; }
        public bool photos_processing { get; set; }
        public bool photo_optimizer_enabled { get; set; }
        public bool photo_optimizer_has_result { get; set; }
        public bool spotify_connected { get; set; }
        public bool spotify_anthem { get; set; }
        public bool squads_discoverable { get; set; }
        public List<object> squads { get; set; }
        public bool can_create_squad { get; set; }
        public bool squad_ads_shown { get; set; }
        public string phone_id { get; set; }
        public EmailSettings email_settings { get; set; }
    }


  

}
