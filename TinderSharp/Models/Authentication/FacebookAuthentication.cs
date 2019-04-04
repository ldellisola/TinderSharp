using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.Authentication
{
    public class FacebookAuthentication
    {
        public string facebook_token { get; set; }
        public int facebook_id { get; set; }
    }

    public class SMSAuthentication
    {
        public string token { get; set; }
        public string id { get; set; }
        public string client_version { get; set; } = "9.0.1";
    }

}
