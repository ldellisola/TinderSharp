using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using TinderSharp.Models.User;

namespace TinderSharp.Models.Images
{
    public partial class Photo
    {
        public Guid Id { get; set; }
        public Uri Url { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string FbId { get; set; }
        public List<ProcessedFile> ProcessedFiles { get; set; }
        public CropInfo crop_info { get; set; }

        public class ProcessedFile
        {

            [JsonProperty("url")]
            public string url { get; set; }

            [JsonProperty("height")]
            public int height { get; set; }

            [JsonProperty("width")]
            public int width { get; set; }
        }

        public class CropInfo
        {

            [JsonProperty("user")]
            public UserPicture user { get; set; }

            [JsonProperty("algo")]
            public Algo algo { get; set; }

            [JsonProperty("processed_by_bullseye")]
            public bool processed_by_bullseye { get; set; }

            [JsonProperty("user_customized")]
            public bool user_customized { get; set; }

            public class UserPicture
            {

                [JsonProperty("width_pct")]
                public double width_pct { get; set; }

                [JsonProperty("x_offset_pct")]
                public double x_offset_pct { get; set; }

                [JsonProperty("height_pct")]
                public double height_pct { get; set; }

                [JsonProperty("y_offset_pct")]
                public double y_offset_pct { get; set; }
            }

            public class Algo
            {

                [JsonProperty("width_pct")]
                public double width_pct { get; set; }

                [JsonProperty("x_offset_pct")]
                public double x_offset_pct { get; set; }

                [JsonProperty("height_pct")]
                public double height_pct { get; set; }

                [JsonProperty("y_offset_pct")]
                public double y_offset_pct { get; set; }
            }

        }
    }
}
