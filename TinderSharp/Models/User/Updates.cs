using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TinderSharp.Models.Images;

namespace TinderSharp.Models.User
{
    public class Seen
    {

        [JsonProperty("match_seen")]
        public bool match_seen { get; set; }

        [JsonProperty("last_seen_msg_id")]
        public string last_seen_msg_id { get; set; }
    }

   

    

    


    

    public class PhotoUpdates
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("processedFiles")]
        public IList<Photo.ProcessedFile> processedFiles { get; set; }

        [JsonProperty("fileName")]
        public string fileName { get; set; }

        [JsonProperty("extension")]
        public string extension { get; set; }

        [JsonProperty("main")]
        public bool main { get; set; }

        [JsonProperty("xoffset_percent")]
        public double xoffset_percent { get; set; }

        [JsonProperty("yoffset_percent")]
        public double yoffset_percent { get; set; }

        [JsonProperty("xdistance_percent")]
        public double xdistance_percent { get; set; }

        [JsonProperty("ydistance_percent")]
        public double ydistance_percent { get; set; }

        [JsonProperty("crop_info")]
        public Photo.CropInfo crop_info { get; set; }

        [JsonProperty("shape")]
        public string shape { get; set; }

        [JsonProperty("selectRate")]
        public double? selectRate { get; set; }
    }

    public class Person
    {

        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("bio")]
        public string bio { get; set; }

        [JsonProperty("birth_date")]
        public DateTime birth_date { get; set; }

        [JsonProperty("gender")]
        public int gender { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("ping_time")]
        public DateTime ping_time { get; set; }

        [JsonProperty("photos")]
        public IList<Photo> photos { get; set; }

        [JsonProperty("hide_distance")]
        public bool? hide_distance { get; set; }

        [JsonProperty("hide_age")]
        public bool? hide_age { get; set; }
    }


    public class LikedMessage
    {

        [JsonProperty("message_id")]
        public string message_id { get; set; }

        [JsonProperty("updated_at")]
        public string updated_at { get; set; }

        [JsonProperty("liker_id")]
        public string liker_id { get; set; }

        [JsonProperty("match_id")]
        public string match_id { get; set; }

        [JsonProperty("is_liked")]
        public bool is_liked { get; set; }
    }

    public class PollInterval
    {

        [JsonProperty("standard")]
        public int standard { get; set; }

        [JsonProperty("persistent")]
        public int persistent { get; set; }
    }

    public class Places
    {

        [JsonProperty("has_new")]
        public bool has_new { get; set; }
    }

    public class Update
    {

        [JsonProperty("matches")]
        public IList<MatchResponse.Match> matches { get; set; }

        [JsonProperty("blocks")]
        public IList<string> blocks { get; set; }

        [JsonProperty("inbox")]
        public IList<object> inbox { get; set; }

        [JsonProperty("liked_messages")]
        public IList<LikedMessage> liked_messages { get; set; }

        [JsonProperty("lists")]
        public IList<object> lists { get; set; }

        [JsonProperty("goingout")]
        public IList<object> goingout { get; set; }

        [JsonProperty("deleted_lists")]
        public IList<object> deleted_lists { get; set; }

        [JsonProperty("squads")]
        public IList<object> squads { get; set; }

        [JsonProperty("last_activity_date")]
        public DateTime last_activity_date { get; set; }

        [JsonProperty("poll_interval")]
        public PollInterval poll_interval { get; set; }

        [JsonProperty("places")]
        public Places places { get; set; }
    }

}
