using System;
using TinderSharp;
using TinderSharp.Services;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TinderClient("82fd8255-5e23-4696-a51f-7023a2c3ac11");

            // var resp = client.GetProfile();
            var resp2 = client.GetMetadata();
        }
    }
}


