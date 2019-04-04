using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string tok = "EAAGm0PX4ZCpsBALXEeZBUqAyXoEIbIAfQ7hWC8jXGdp79rhqauPCxw1Nw7N8uD46W40HRzC1p97JWLEDISHZAa1mZBJV4EcOkACMNAnZALEZCZAWoNEX9R9OiEUs54ZApRKQpGUOZBeFSTFErClZBhDbj151QewWPEQWPJ2Cf3AS26hobLNn4ZCFY5YgkFYkXhemC0ZD";

            var usr = TinderSharp.Services.Authenticator.Authenticate(tok, 1605746836);

            TinderSharp.Services.User.GetMetadata(usr.Token);
            TinderSharp.Services.User.GetMetadataV2(usr.Token);
            TinderSharp.Services.User.GetUpdates(usr.Token,new DateTime(2018,12,30));

        }
    }
}


