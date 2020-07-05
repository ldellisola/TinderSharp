using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TinderSharp.Models.Matches;
using TinderSharp.Models.User;

namespace TinderSharp.Json
{
    public class MatchResponseConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(MatchResponse.Match));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                return token.ToObject<MatchResponse.Match>();
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}