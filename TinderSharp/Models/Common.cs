using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TinderSharp.Models.User
{

    public enum Gender
    {
        Everyone = -1,
        Male = 0,
        Female = 1
    }
    public class School
    {
        [JsonProperty("displayed")] public bool IsDisplayed { get; set; }
        [JsonProperty("metadata_id")] public string MetadataId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }

    public class Interest
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }

    public class Badge
    {
        [JsonProperty("type")] public string Type { get; set; }
    }

    public class Job
    {
        [JsonProperty("company")] public HideableField Company  { get; set; }
        [JsonProperty("title")] public HideableField Title { get; set; }
    }

    public class HideableField
    {
        [JsonProperty("displayed")]public bool Displayed { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }

    public class SearchPreferences
    {
        // Min age match. Must be 18+
        [JsonProperty("age_filter_min")] public int MinAgeFilter { get; set; }
  
        [JsonProperty("age_filter_max")] public int MaxAgeFilter { get; set; }

        // max search radius in kilometers
        [JsonProperty("distance_filter")] public int MaxDistanceFilter { get; set; }

        // YOUR gender. 0: Male, 1: Female
        [JsonProperty("gender")] public Gender PreferedGender { get; set; }

        public bool Validate()
        {
            return MinAgeFilter >= 18 && MaxAgeFilter > MinAgeFilter && MaxDistanceFilter > 0;
        }
    }

}
