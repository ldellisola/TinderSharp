using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TinderSharp.Models.User;

namespace TinderSharp.Json
{
    internal class ConventionBasedConverter<T> : JsonConverter where T : new()
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var data = JObject.Load(reader);
            var ret = new T();

            foreach (var prop in ret.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance))
            {
                var attr = prop.GetCustomAttributes(false).FirstOrDefault();
                if (attr != null)
                {
                    var propName = ((JsonPropertyAttribute) attr).PropertyName;
                    if (!string.IsNullOrWhiteSpace(propName))
                    {
                        var conventions = propName.Split('.');

                        var token = data[conventions[0]];

                        for (int i = 1; i < conventions.Length; i++)
                        {
                            token = token[conventions[i]];
                        }

                        prop.SetValue(ret, token.ToObject(prop.PropertyType));
                    }

                }
                
            }

            return ret;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
