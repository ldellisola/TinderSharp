using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{

    public partial class TinderProfile
    {
        public string Id { get; set; }
        public long AgeFilterMax { get; set; }
        public long AgeFilterMin { get; set; }
        public string Bio { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public bool Discoverable { get; set; }
        public long DistanceFilter { get; set; }
        public EmailSettings EmailSettings { get; set; }
        public long FacebookId { get; set; }
        public long Gender { get; set; }
        public long GenderFilter { get; set; }
        public List<long> InterestedIn { get; set; }
        public List<Job> Jobs { get; set; }
        public string Name { get; set; }
        public List<Photo> Photos { get; set; }
        public bool PhotoOptimizerEnabled { get; set; }
        public bool PhotoOptimizerHasResult { get; set; }
        public DateTimeOffset PingTime { get; set; }
        public Position Pos { get; set; }
        public PositionInfo PosInfo { get; set; }
        public List<School> Schools { get; set; }
        public string Username { get; set; }
        public bool CanCreateSquad { get; set; }
    }

    public partial class EmailSettings
    {
        public bool NewMatches { get; set; }
        public bool Messages { get; set; }
        public bool Promotions { get; set; }
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
