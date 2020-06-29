using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TinderSharp.Services.Messages
{
    public class SpotifySongMessage : ISongMessage
    {
        private string trackId;
        public SpotifySongMessage(Uri url)
        {
            var regex = Regex.Match(url.AbsoluteUri,@"https:\/\/open\.spotify\.com\/track\/(.+)");

            if(!regex.Success)
                throw new ArgumentException("The URI does not belong to spotify");

            trackId = regex.Groups[1].Value;
        }
        public Uri GetUri()
        {
            return new Uri(@"https://open.spotify.com/track/" + trackId);
        }

        public string GetSongId()
        {
            return trackId;
        }
    }
}
