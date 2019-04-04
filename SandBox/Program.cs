using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string tok = "EAAGm0PX4ZCpsBANJnOqTBfO3yRAmUhUT4LNq4lyQOV3ENeedwXQKbwD9ZBFIr6U2ULMc7oiHCP7WBEIdej812ZAcVdCKagLpkmMtf1u0gD7LNowew2oCWWnRiLUwwE8JHxzFU7RGdrz41zr7PXMZBi8CNoR02hktu7CSnClxUXUIPUdmumHLKcZCNjbPyijEZD";

            var usr = TinderSharp.Services.Authenticator.Authenticate(tok, 1605746836);

            //TinderSharp.Services.User.GetMetadata(usr.Token);
            TinderSharp.Services.User.GetUpdates(usr.Token);
            //TinderSharp.Services.User.GetUpdates(usr.Token,new DateTime(2018,12,30));

            //TinderSharp.Services.User.MessageMatch(usr.Token, info.Results[0]._id, "Test");
        }
    }
}


