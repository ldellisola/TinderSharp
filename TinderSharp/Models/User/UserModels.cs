using System;
using System.Collections.Generic;
using System.Text;
using TinderSharp.Models.Images;

namespace TinderSharp.Models.User
{

    public partial class LoggedUser
    {
        public List<string> Groups { get; set; }
        public User User { get; set; }
        public Guid Token { get; set; }
        public Versions Versions { get; set; }
        public Globals Globals { get; set; }
    }

    public partial class Globals
    {
        public bool Friends { get; set; }
        public string invite_type { get; set; }
        public long recs_interval { get; set; }
        public long updates_interval { get; set; }
        public long recs_size { get; set; }
        public string matchmaker_default_message { get; set; }
        public string share_default_text { get; set; }
        public long boost_decay { get; set; }
        public long boost_Up { get; set; }
        public long boost_down { get; set; }
        public bool sparks { get; set; }
        public bool kontagent { get; set; }
        public bool sparks_enabled { get; set; }
        public bool kontagen_enabled { get; set; }
        public bool mqtt { get; set; }
        public bool tinder_sparks { get; set; }
        public long moments_interval { get; set; }
        public bool fetch_connections { get; set; }
        public bool plus { get; set; }
    }

    public partial class User
    {
        public string _id { get; set; }
        public DateTimeOffset active_time { get; set; }
        public DateTimeOffset create_date { get; set; }
        public long age_filter_max { get; set; }
        public long age_filter_min { get; set; }
        public Guid api_token { get; set; }
        public bool banned { get; set; }
        public string Bio { get; set; }
        public DateTimeOffset birth_date { get; set; }
        public long connection_count { get; set; }
        public long distance_filter { get; set; }
        public string full_name { get; set; }
        public List<string> Groups { get; set; }
        public long gender { get; set; }
        public long gender_filter { get; set; }
        public List<Profile.UserData.Interest> Interests { get; set; }
        public string Name { get; set; }
        public DateTimeOffset ping_time { get; set; }
        public bool Discoverable { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Job> Jobs { get; set; }
        public List<School> Schools { get; set; }
        public string Username { get; set; }
    }

    
    public partial class Versions
    {
        public string active_text { get; set; }
        public string age_filter { get; set; }
        public string Matchmaker { get; set; }
        public string Trending { get; set; }
        public string trending_active_text { get; set; }
    }
}
