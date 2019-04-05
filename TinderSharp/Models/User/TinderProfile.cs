using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{

    public partial class TinderProfile
    {
        public string Id { get; set; }
        public long age_filter_max { get; set; }
        public long age_filter_min { get; set; }
        public string Bio { get; set; }
        public DateTimeOffset birth_date { get; set; }
        public DateTimeOffset create_date { get; set; }
        public bool Discoverable { get; set; }
        public long distance_filter { get; set; }
        public EmailSettings email_settings { get; set; }
        public long facebook_id { get; set; }
        public long Gender { get; set; }
        public long gender_filter { get; set; }
        public List<long> interested_in { get; set; }
        public List<Job> Jobs { get; set; }
        public string Name { get; set; }
        public List<Photo> Photos { get; set; }
        public bool photo_optimizer_enabled { get; set; }
        public bool photo_optimizer_has_result { get; set; }
        public DateTimeOffset ping_time { get; set; }
        public Position Pos { get; set; }
        public PositionInfo pos_info { get; set; }
        public List<School> Schools { get; set; }
        public string Username { get; set; }
        public bool can_create_squad { get; set; }
    }

    public partial class EmailSettings
    {
        public bool new_matches { get; set; }
        public bool messages { get; set; }
        public bool promotions { get; set; }
    }

    public partial class Position
    {
        public long At { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public partial class PositionInfo
    {
        public State State { get; set; }
        public Country Country { get; set; }
    }

    public partial class State
    {
        public string Name { get; set; }
        public Bounds Bounds { get; set; }
    }

    public partial class Country
    {
        public string Name { get; set; }
        public string Cc { get; set; }
        public Bounds Bounds { get; set; }
    }

    public partial class Bounds
    {
        public Coordinates Ne { get; set; }
        public Coordinates Sw { get; set; }
    }

    public partial class Coordinates
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

}
