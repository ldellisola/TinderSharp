using System;
using TinderSharp.Models.Authentication;

namespace TinderSharp.Services.Authentication
{
    public class SMSAuthenticator : IAuthenticator
    {
        private const string SMSAuth = @"/v2/auth/login/sms";
        private const string SMSAuthValidation = @"/v2/auth/login/sms/validate";
        private string PhoneNumber { get; set; }

        public SMSAuthenticator(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public void RequestSMS()
        {
            var response = new RestClient(SMSAuth).Post<SMSAuthenticationResponse>(new
            {
                phone_number = PhoneNumber
            });
        }

        public void ValidateSMS(string SmsCode)
        {
            var response = new RestClient(SMSAuthValidation).Post<SMSValidationResponse>(new
            {
                phone_number = PhoneNumber,
                otp_code = SmsCode,
                is_update = false
            });


        }


        public string GetXAuthToken()
        {
            throw new NotImplementedException();
        }

        public void Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}