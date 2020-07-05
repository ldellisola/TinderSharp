using System.Collections.Generic;
using Newtonsoft.Json;
using TinderSharp.Models.User;

namespace TinderSharp.Models.Matches
{
    public class MatchedPerson : Person
    {
        [JsonProperty("common_interests")] public IList<Interest> CommonInterests { get; set; }
        [JsonProperty("distance_mi")] public int DistanceInMiles { get; set; }
        [JsonProperty("is_tinder_u")] public bool IsTinderUniversity { get; set; }
        [JsonProperty("jobs")] public IList<Job> Jobs { get; set; }
        [JsonProperty("schools")] public IList<School> Schools { get; set; }

    }
}