using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models
{
    public class UrlQueryBuilder
    {
        private UrlQuery _query = new UrlQuery();

        public void Reset()
        {
            _query = new UrlQuery();
        }

        internal void Add(string key, string value)
        {
            _query.Add(key,value);
        }
        public UrlQuery Build()
        {
            return _query;
        }

        public UrlQueryBuilder AddLocale(string locale)
        {
            _query.Add("locale", locale);
            return this;
        }
    }
}
