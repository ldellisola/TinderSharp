using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TinderSharp.Models.Authentication
{
    public class SMSAuthenticationResponse
    {
        [JsonProperty("otpLenght")] public int OtpLenght { get; set; }
        [JsonProperty("smsSent")] public bool WasSMSSent { get; set; }
    }

    public class SMSValidationResponse
    {
        [JsonProperty("refreshToken")] public int XAuthToken { get; set; }
        [JsonProperty("validated")] public bool WasValidated { get; set; }
    }
}
