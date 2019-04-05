using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{
    public class Seen
    {

        [JsonProperty("match_seen")]
        public bool match_seen { get; set; }

        [JsonProperty("last_seen_msg_id")]
        public string last_seen_msg_id { get; set; }
    }

    public class Message
    {

        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("match_id")]
        public string match_id { get; set; }

        [JsonProperty("sent_date")]
        public DateTime sent_date { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("to")]
        public string to { get; set; }

        [JsonProperty("from")]
        public string from { get; set; }

        [JsonProperty("created_date")]
        public DateTime created_date { get; set; }

        [JsonProperty("timestamp")]
        public object timestamp { get; set; }

        [JsonProperty("fixed_height")]
        public string fixed_height { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }

    public class ProcessedFile
    {

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }
    }

    public class UserPitcture
    {

        [JsonProperty("width_pct")]
        public double width_pct { get; set; }

        [JsonProperty("x_offset_pct")]
        public double x_offset_pct { get; set; }

        [JsonProperty("height_pct")]
        public double height_pct { get; set; }

        [JsonProperty("y_offset_pct")]
        public double y_offset_pct { get; set; }
    }

    public class Algo
    {

        [JsonProperty("width_pct")]
        public double width_pct { get; set; }

        [JsonProperty("x_offset_pct")]
        public double x_offset_pct { get; set; }

        [JsonProperty("height_pct")]
        public double height_pct { get; set; }

        [JsonProperty("y_offset_pct")]
        public double y_offset_pct { get; set; }
    }

    public class CropInfo
    {

        [JsonProperty("user")]
        public UserPitcture user { get; set; }

        [JsonProperty("algo")]
        public Algo algo { get; set; }

        [JsonProperty("processed_by_bullseye")]
        public bool processed_by_bullseye { get; set; }

        [JsonProperty("user_customized")]
        public bool user_customized { get; set; }
    }

    public class PhotoUpdates
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> processedFiles { get; set; }

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
        public CropInfo crop_info { get; set; }

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

    public class Match
    {

        [JsonProperty("seen")]
        public Seen seen { get; set; }

        [JsonProperty("_id")]
        public string _id { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

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
        public IList<Match> matches { get; set; }

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
