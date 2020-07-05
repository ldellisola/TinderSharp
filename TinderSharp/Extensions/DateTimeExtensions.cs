using System;

namespace TinderSharp.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToTinderString(this DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
        }
    }
}