using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Json;
using TinderSharp.Models.Images;
using TinderSharp.Models.Music;

namespace TinderSharp.Models.User
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
            public Seen seen { get; set; }

            [JsonProperty("_id")]
            public string Id { get; set; }

            [JsonProperty("closed")]
            public bool closed { get; set; }

            [JsonProperty("common_friend_count")]
            public int common_friend_count { get; set; }

            [JsonProperty("common_like_count")]
            public int common_like_count { get; set; }

            [JsonProperty("created_date")]
            public DateTime created_date { get; set; }

            [JsonProperty("dead")]
            public bool dead { get; set; }

            [JsonProperty("last_activity_date")]
            public DateTime last_activity_date { get; set; }

            [JsonProperty("message_count")]
            public int message_count { get; set; }

            [JsonProperty("messages")]
            public IList<Message> messages { get; set; }

            [JsonProperty("muted")]
            public bool muted { get; set; }

            [JsonProperty("participants")]
            public IList<string> participants { get; set; }

            [JsonProperty("pending")]
            public bool pending { get; set; }

            [JsonProperty("is_super_like")]
            public bool is_super_like { get; set; }

            [JsonProperty("is_boost_match")]
            public bool is_boost_match { get; set; }

            [JsonProperty("is_fast_match")]
            public bool is_fast_match { get; set; }

            [JsonProperty("person")]
            public Person person { get; set; }

            [JsonProperty("following")]
            public bool following { get; set; }

            [JsonProperty("following_moments")]
            public bool following_moments { get; set; }

            [JsonProperty("super_liker")]
            public string super_liker { get; set; }
        }

    }


    public class RecommendedMatches
    {
        public List<RecommendedMatch> Results { get; set; }
    }
    public partial class RecommendedMatch
    {
        public bool group_matched { get; set; }
        public long distance_mi { get; set; }
        public string content_hash { get; set; }
        public List<object> common_friends { get; set; }
        public List<object> common_likes { get; set; }
        public long common_friend_count { get; set; }
        public long common_like_count { get; set; }
        public long connection_count { get; set; }
        public string _id { get; set; }
        public string bio { get; set; }
        public DateTimeOffset birth_date { get; set; }
        public string name { get; set; }
        public DateTimeOffset ping_time { get; set; }
        public List<ResultPhoto> photos { get; set; }
        public Instagram instagram { get; set; }
        public List<MatchJob> jobs { get; set; }
        public List<MatchSchool> schools { get; set; }
        public Teaser teaser { get; set; }
        public List<Teaser> teasers { get; set; }
        public long gender { get; set; }
        public long s_number { get; set; }
        public List<SpotifyTopArtist> SpotifyTopArtists { get; set; }
        public Song SpotifyThemeTrack { get; set; }
        public bool? IsTraveling { get; set; }
    }

    public partial class Instagram
    {
        public DateTimeOffset last_fetch_time { get; set; }
        public bool completed_initial_fetch { get; set; }
        public List<InstagramPhoto> photos { get; set; }
        public long media_count { get; set; }
        public Uri profile_picture { get; set; }
        public string username { get; set; }
    }

    public partial class InstagramPhoto
    {
        public Uri image { get; set; }
        public Uri thumbnail { get; set; }
        public long ts { get; set; }
        public Uri link { get; set; }
    }

    public partial class MatchJob
    {
        public School title { get; set; }
    }

    public partial class MatchSchool
    {
        public string name { get; set; }
    }

    public partial class ResultPhoto
    {
        public Guid id { get; set; }
        public Photo.CropInfo crop_info { get; set; }
        public Uri url { get; set; }
        public List<Photo.ProcessedFile> processedFiles { get; set; }
        public string fileName { get; set; }
        public string extension { get; set; }
        public bool? main { get; set; }
        public List<Photo.ProcessedFile> processedVideos { get; set; }
    }

    public partial class SpotifyTopArtist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Song top_track { get; set; }
        public bool Selected { get; set; }
    }

    public partial class Teaser
    {
        public string String { get; set; }
        public string Type { get; set; }
    }

}
