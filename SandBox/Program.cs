using System;
using System.Threading.Tasks;
using TinderSharp;
using TinderSharp.Models;
using TinderSharp.Services;
using TinderSharp.Services.Messages;

namespace SandBox
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new TinderClient("1c26e913-bee5-4b68-8fbc-41a2b66991a8");

            // var resp = client.GetProfile();
            var metadata = await client.GetMetadata();

            var profile = await client.GetProfile();
            var recommendations = await client.GetMatchRecommendations();

            var matches = await client.GetMatches(new UrlQueryBuilder().AddMatchesCount(10).Build());
            var moreMatches = await client.GetMessagedMatches(new UrlQueryBuilder().AddMatchesCount(10).Build());

            var update = await client.GetUpdates(DateTime.Now.AddMonths(-5));
            

        }
    }
}


