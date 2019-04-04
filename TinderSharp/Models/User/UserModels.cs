using System;
using System.Collections.Generic;
using System.Text;

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
        public string InviteType { get; set; }
        public long RecsInterval { get; set; }
        public long UpdatesInterval { get; set; }
        public long RecsSize { get; set; }
        public string MatchmakerDefaultMessage { get; set; }
        public string ShareDefaultText { get; set; }
        public long BoostDecay { get; set; }
        public long BoostUp { get; set; }
        public long BoostDown { get; set; }
        public bool Sparks { get; set; }
        public bool Kontagent { get; set; }
        public bool SparksEnabled { get; set; }
        public bool KontagentEnabled { get; set; }
        public bool Mqtt { get; set; }
        public bool TinderSparks { get; set; }
        public long MomentsInterval { get; set; }
        public bool FetchConnections { get; set; }
        public bool Plus { get; set; }
    }

    public partial class User
    {
        public string Id { get; set; }
        public DateTimeOffset ActiveTime { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public long AgeFilterMax { get; set; }
        public long AgeFilterMin { get; set; }
        public Guid ApiToken { get; set; }
        public bool Banned { get; set; }
        public string Bio { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public long ConnectionCount { get; set; }
        public long DistanceFilter { get; set; }
        public string FullName { get; set; }
        public List<string> Groups { get; set; }
        public long Gender { get; set; }
        public long GenderFilter { get; set; }
        public List<Interest> Interests { get; set; }
        public string Name { get; set; }
        public DateTimeOffset PingTime { get; set; }
        public bool Discoverable { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Job> Jobs { get; set; }
        public List<School> Schools { get; set; }
        public string Username { get; set; }
    }

    public partial class Interest
    {
        public string Id { get; set; }
        public string CreatedTime { get; set; }
        public string Name { get; set; }
    }

    public partial class Versions
    {
        public string ActiveText { get; set; }
        public string AgeFilter { get; set; }
        public string Matchmaker { get; set; }
        public string Trending { get; set; }
        public string TrendingActiveText { get; set; }
    }
}
