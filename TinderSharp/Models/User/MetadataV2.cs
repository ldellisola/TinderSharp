using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{
    public partial class MetadataV2Container
    {
        public MetadataV2 Data { get; set; }
    }

    public partial class MetadataV2
    {
        public ClientResources client_resources { get; set; }
        public Account Account { get; set; }
        public CreditCard credit_card { get; set; }
        public BoostV2 Boost { get; set; }
        public FastMatch fast_match { get; set; }
        public BackgroundLocation gold_homepage { get; set; }
        public TopPicks top_picks { get; set; }
        public BackgroundLocation intro_pricing { get; set; }
        public Paywall Paywall { get; set; }
        public Merchandising Merchandising { get; set; }
        public Recs Recs { get; set; }
        public TinderPlusMetadataV2 tinder_plus { get; set; }
        public SuperLike super_like { get; set; }
        public ProfileMetadata Profile { get; set; }
        public Select Select { get; set; }
        public Feedback Feedback { get; set; }
        public TypingIndicator typing_indicator { get; set; }
        public PlacesMedatada Places { get; set; }
        public BackgroundLocation terms_of_service { get; set; }
        public SwipeSurge swipe_surge { get; set; }
        public BackgroundLocation crm_inbox { get; set; }
        public BackgroundLocation background_location { get; set; }
        public BackgroundLocation tinderu_swipe_off_2019 { get; set; }
        public Levers Levers { get; set; }
    }

    public partial class Account
    {
        public bool email_prompt_required { get; set; }
        public bool email_prompt_dismissible { get; set; }
        public bool email_prompt_show_marketing_opt_in { get; set; }
        public bool email_prompt_show_strict_opt_in { get; set; }
        public string web_permission_prompt_style { get; set; }
        public string web_desktop_onboarding_style { get; set; }
        public string web_desktop_matchlist_style { get; set; }
    }

    public partial class BackgroundLocation
    {
        public bool Enabled { get; set; }
    }

    public partial class BoostV2 : Boost
    {
        public bool enabled { get; set; }
        public long duration { get; set; }
        public long intro_multiplier { get; set; }
    }

    public partial class ClientResources
    {
        public RateCard rate_card { get; set; }
        public List<string> plus_screen { get; set; }
    }


    public partial class FastMatch
    {
        public bool enabled { get; set; }
        public long preview_minimum_time { get; set; }
        public List<long> notif_options { get; set; }
        public long notif_defaults { get; set; }
        public long new_count_fetch_interval { get; set; }
        public long boost_new_count_fetch_interval { get; set; }
        public long new_count_threshold { get; set; }
        public long polling_mode { get; set; }
        public bool entry_point { get; set; }
        public bool use_teaser_endpoint { get; set; }
    }

    public partial class Feedback
    {
        public bool rate_app { get; set; }
    }

    public partial class Levers
    {
    }

    public partial class Merchandising
    {
        public bool gold_v1_enabled { get; set; }
        public bool gold_v2_enabled { get; set; }
    }

    public partial class Paywall
    {
        public bool full_price { get; set; }
        public bool E1 { get; set; }
        public bool E2 { get; set; }
        public bool bouncer_avatar { get; set; }
        public long E3 { get; set; }
        public long E4 { get; set; }
    }

    public partial class ProfileMetadataV2 :ProfileMetadata
    {
        public bool can_edit_jobs { get; set; }
        public bool can_edit_schools { get; set; }
        public bool can_edit_email { get; set; }
        public bool can_add_photos_from_facebook { get; set; }
        public bool can_show_common_connections { get; set; }

    }

    public partial class Recs
    {
        public bool card_replay { get; set; }
    }

    public partial class Select
    {
        public bool enabled { get; set; }
        public bool recs_enabled { get; set; }
        public bool invited { get; set; }
    }

    public partial class SuperLike
    {
        public bool enabled { get; set; }
        public long alc_mode { get; set; }
    }


    public partial class TinderPlusMetadataV2
    {
        public bool enabled { get; set; }
        public bool discount { get; set; }
    }

    public partial class TopPicks
    {
        public bool Enabled { get; set; }
        public bool local_daily_enabled { get; set; }
        public string local_daily_msg { get; set; }
        public LocalDailyOffsets local_daily_offsets { get; set; }
        public bool free_daily { get; set; }
        public long num_free_rated_limit { get; set; }
        public long refresh_interval { get; set; }
        public long Lookahead { get; set; }
        public bool post_swipe_paywall { get; set; }
    }

    public partial class LocalDailyOffsets
    {
        public long Offset0 { get; set; }
        public long Offset1 { get; set; }
        public long Offset2 { get; set; }
        public long Offset3 { get; set; }
    }

}
