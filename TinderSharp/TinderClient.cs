using System;
using System.Collections.Generic;
using System.Text;
using TinderSharp.Services.Authentication;

namespace TinderSharp
{
    public class TinderClient
    {
        public string XAuthToken {  get; }
        public TinderClient(IAuthenticator authenticator)
        {
            XAuthToken = authenticator.GetXAuthToken();
        }
        public TinderClient(string xAuthToken)
        {
            XAuthToken = xAuthToken;
        }

        public static class TinderAPI
        {
            public const string Authenticate = @"/v3/auth/login?locale=en";







            // funciona


        }
    }

}
