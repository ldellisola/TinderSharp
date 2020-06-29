using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TinderSharp.Models.Images;
using TinderSharp.Models.User;

namespace TinderSharp.Models.Music
{
    public class Song
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("url")] public Uri Sample { get; set; }
        [JsonProperty("album")] public Album Album { get; set; }
        [JsonProperty("artists")] public IList<Artist> Artists { get; set; }
    }

    public class Album
    {
        public string Name { get; set; }
        public List<Photo.ProcessedFile> Images { get; set; }
    }

    public class Artist
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}