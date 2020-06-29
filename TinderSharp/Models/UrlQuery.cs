using System;
using System.Collections.Generic;

namespace TinderSharp.Models
{
    public class UrlQuery
    {

        public List<Tuple<string, string>> values = new List<Tuple<string, string>>();
        public string Generate()
        {
            string ret = "?";
            values.ForEach(t => ret += (t.Item1 + "=" + t.Item2 + "&"));

            return ret;
        }

        public void Add(string key, string value)
        {
            values.Add(new System.Tuple<string, string>(key,value));
        }
    }
}