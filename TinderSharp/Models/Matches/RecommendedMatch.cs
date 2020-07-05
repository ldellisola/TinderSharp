using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TinderSharp.Json;
using TinderSharp.Models.ExternalServices;
using TinderSharp.Models.Images;
using TinderSharp.Models.User;

namespace TinderSharp.Models.Matches
{
    public class MatchResponse
    {
        [JsonProperty("likes_remaining")] public int LikesRemaining { get; set; }

        [JsonConverter(typeof(MatchResponseConverter))]
        [JsonProperty("match")]
        public Match IsMatch { get; set; }

        public class Match
        {
            [JsonProperty("seen")]
            public Seen MatchSeen { get; set; }

            [JsonProperty("_id")]
            public string Id { get; set; }

            [JsonProperty("closed")]
            public bool IsClosed { get; set; }

            [JsonProperty("created_date")]
            public DateTime MatchedDate { get; set; }

            [JsonProperty("dead")]
            public bool IsDead { get; set; }

            [JsonProperty("last_activity_date")]
            public DateTime LastActive { get; set; }

            [JsonProperty("message_count")]
            public int MessageCount { get; set; }

            [JsonProperty("messages")]
            public IList<Message> Messages { get; set; }

            [JsonProperty("muted")]
            public bool IsMuted { get; set; }

            [JsonProperty("pending")]
            public bool IsPending { get; set; }

            [JsonProperty("is_super_like")]
            public bool IsSuperLike { get; set; }

            [JsonProperty("is_boost_match")]
            public bool IsBoostedMatch { get; set; }

            [JsonProperty("is_fast_match")]
            public bool IsFastMatch { get; set; }

            [JsonProperty("person")]
            public Person Person { get; set; }

            [JsonProperty("following")]
            public bool IsFollowing { get; set; }

            [JsonProperty("following_moments")]
            public bool IsFollowingMoments { get; set; }

            [JsonProperty("super_liker")]
            public string SuperLiker { get; set; }

            public class Seen
            {

                [JsonProperty("match_seen")]
                public bool WasSeen { get; set; }

                [JsonProperty("last_seen_msg_id")]
                public string LastSeenMessageId { get; set; }
            }
        }

    }


    public class RecommendedMatches
    {
        [JsonProperty("results")] public List<RecommendedMatch> Results { get; set; }
    }
    public class RecommendedMatch
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("user")] public User MatchUser { get; set; }
        [JsonProperty("distance_mi")] public long DistanceInMiles { get; set; }
        [JsonProperty("content_hash")] public string ContentHash { get; set; }
        [JsonProperty("instagram")] public Instagram Instagram { get; set; }
        [JsonProperty("spotify")] public Spotify Spotify { get; set; }
        [JsonProperty("teaser")] public Teaser MatchTeaser { get; set; }
        [JsonProperty("teasers")] public List<Teaser> Teasers { get; set; }
        [JsonProperty("s_number")] public long SNumber { get; set; }

        public class User
        {
            [JsonProperty("_id")] public string Id { get; set; }
            [JsonProperty("badges")] public IList<Badge> Badges { get; set; }
            [JsonProperty("bio")] public string Biography { get; set; }
            [JsonProperty("birth_date")] public DateTime BirthDate { get; set; }
            [JsonProperty("name")] public string Name { get; set; }
            [JsonProperty("photos")] public List<Photo> Photos { get; set; }
            [JsonProperty("gender")] public Gender Gender { get; set; }
            [JsonProperty("jobs")] public List<Job> Jobs { get; set; }
            [JsonProperty("schools")] public List<School> Schools { get; set; }
        }

        public class Teaser
        {
            [JsonProperty("string")] public string Text { get; set; }
            [JsonProperty("type")] public string Type { get; set; }
        }
    }

    




}
