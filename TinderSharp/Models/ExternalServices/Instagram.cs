using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Models.Music;

namespace TinderSharp.Models.ExternalServices
{
    public class Instagram
    {
        
        [JsonProperty("last_fetch_time")] public DateTimeOffset LastFetchTime { get; set; }
        [JsonProperty("completed_initial_fetch")] public bool IsFetchCompleted  { get; set; }
        [JsonProperty("photos")] public List<Photo> Photos { get; set; }
        [JsonProperty("media_count")] public long AmmountOfPictures { get; set; }

        public class Photo
        {
            [JsonProperty("image")] public Uri Image { get; set; }
            [JsonProperty("thumbnail")] public Uri Thumbnail { get; set; }
            [JsonProperty("ts")] public long TimeStamp { get; set; }
        }
    }

    


    
}
