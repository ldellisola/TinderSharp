using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TinderSharp.Models.Music;
using TinderSharp.Models.User;

namespace TinderSharp.Models
{
    public class Message
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("sent_date")]
        public DateTime SentDate { get; set; }

        [JsonProperty("message")]
        public string Content { get; set; }

        [JsonProperty("to")]
        public string ToUserId { get; set; }

        [JsonProperty("from")]
        public string FromUserId { get; set; }

        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("type")]
        protected string _type { get; set; }

        [JsonIgnore] public bool IsGif => _type == "gif";

        [JsonProperty("song")] public Song SongData { get; set; }

        

    }


    public class MessagePage
    {
        [JsonProperty("messages")] public IList<Message> Messages { get; set; }
        [JsonProperty("next_page_token")] public string NextPageToken { get; set; }
    }
}