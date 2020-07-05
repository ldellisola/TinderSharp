using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TinderSharp.Models.Matches;
using TinderSharp.Models.User;

namespace TinderSharp.Models
{

    public class Update
    {

        /// <summary>
        /// List of matches confirmed since the date assigned in the update
        /// </summary>
        [JsonProperty("matches")]
        public IList<MatchResponse.Match> Matches { get; internal set; }

        /// <summary>
        /// Uknown
        /// </summary>
        [JsonProperty("blocks")]
        public IList<string> Blocks { get; internal set; }

        /// <summary>
        /// This is a list of messages from Tinder and/or Ad campaigns
        /// </summary>
        [JsonProperty("inbox")]
        public IList<CampaignMessage> inbox { get; internal set; }

        /// <summary>
        /// List of liked messages since the date assigned in the update
        /// </summary>
        [JsonProperty("liked_messages")]
        public IList<LikedMessage> LikedMessages { get; internal set; }

        /// <summary>
        /// Last time the user was connected
        /// </summary>
        [JsonProperty("last_activity_date")]
        public DateTime LastActivity { get; internal set; }


    }



}
