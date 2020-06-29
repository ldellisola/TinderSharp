using System;
using System.Collections.Generic;
using System.Text;
using TinderSharp.Services.Authentication;

namespace TinderSharp
{
    public class TinderClient
    {
        public string XAuthToken {  get; private set; }
        public TinderClient(IAuthenticator authenticator)
        {
            authenticator.Authenticate();
            XAuthToken = authenticator.GetXAuthToken();
        }
        public TinderClient(string xAuthToken)
        {
            XAuthToken = xAuthToken;
        }
    }

}
