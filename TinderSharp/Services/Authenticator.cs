using System;
using System.Collections.Generic;
using TinderSharp.Models.Authentication;
using TinderSharp.Models.User;
using TinderEndpoint;

namespace TinderSharp.Services
{
    public class Authenticator
    {
        public static LoggedUser Authenticate(FacebookAuthentication auth)
        {

            var response = new TinderEndpoint.RestMethods().Post<LoggedUser>(TinderAPI.Authenticate, auth);

            return response;  
        }
        public static LoggedUser Authenticate(string facebookToken, int facebookID)
        {
            FacebookAuthentication auth = new FacebookAuthentication()
            {
                facebook_id = facebookID,
                facebook_token = facebookToken
            };

            return Authenticate(auth);  
        }

        public static LoggedUser Authenticate2FA(SMSAuthentication auth)
        {

            var response = new TinderEndpoint.RestMethods().Post<LoggedUser>(TinderAPI.Authenticate2FA, auth);

            return response;
        }
        public static LoggedUser Authenticate2FA(string token,string id)
        {
            SMSAuthentication auth = new SMSAuthentication()
            {
                id = id,
                token = token
            };

            return Authenticate2FA(auth);
        }
    }
}
