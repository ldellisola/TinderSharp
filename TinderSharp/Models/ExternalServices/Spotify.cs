using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Models.Music;

namespace TinderSharp.Models.ExternalServices
{
    public class Spotify
    {
        [JsonProperty("spotify_connected")] public bool IsConnected { get; set; }
        [JsonProperty("spotify_theme_track")] public Song FavouriteSong { get; set; }
    }
}
