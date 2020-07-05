using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Models.Images;

namespace TinderSharp.Models.User
{
    public class Person
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// It's not an accurate depiction of the birhtdate. The only information that you can get from this value is the year
        /// that person was born
        /// </summary>
        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photos")]
        public IList<Photo> photos { get; set; }
    }

    
}
