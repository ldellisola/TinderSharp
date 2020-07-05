using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TinderSharp.Models.Music;

namespace TinderSharp.Models
{
    public class Message
    {

        [JsonProperty("_id")]
        public string Id { get; internal set; }

        [JsonProperty("match_id")]
        public string MatchId { get; internal set; }

        [JsonProperty("sent_date")]
        public DateTime SentDate { get; internal set; }

        [JsonProperty("message")]
        public string Content { get; internal set; }

        [JsonProperty("to")]
        public string ToUserId { get; internal set; }

        [JsonProperty("from")]
        public string FromUserId { get; internal set; }

        [JsonProperty("created_date")]
        public DateTime CreatedDateinternal { get; set; }

        [JsonProperty("type")] protected string _type { get; set; } = "";

        [JsonIgnore] public bool IsGif => _type == "gif";
        [JsonIgnore] public bool IsSong => _type == "song" || SongData != null;

        [JsonProperty("song")] public Song SongData { get; internal set; }

    }


    public class MessagePage
    {
        [JsonProperty("messages")] public IList<Message> Messages { get; internal set; }
        [JsonProperty("next_page_token")] public string NextPageToken { get; internal set; }
    }

    public class CampaignMessage
    {
        [JsonProperty("type")] public string Type { get; internal set; }
        [JsonProperty("body")] public string Body { get; internal set; }
        [JsonProperty("campaign_id")] public int CampaignId { get; internal set; }
        [JsonProperty("experiment_id")] public int ExperimentId { get; internal set; }
        [JsonProperty("variant_id")] public int? VariantId { get; internal set; }
        [JsonProperty("message_id")] public string MessageId { get; internal set; }
        [JsonProperty("segment_id")] public int SegmentId { get; internal set; }
        [JsonProperty("sent_date")] public DateTime SentDate { get; internal set; }
    }

    public class LikedMessage
    {

        [JsonProperty("message_id")]
        public string MessageId { get; internal set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; internal set; }

        [JsonProperty("liker_id")]
        public string LikerId { get; internal set; }

        [JsonProperty("match_id")]
        public string MatchId { get; internal set; }

        [JsonProperty("is_liked")]
        public bool Isliked { get; internal set; }
    }
}