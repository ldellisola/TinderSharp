namespace TinderSharp.Services.Authentication
{
    public class GoogleAuthenticator : IAuthenticator
    {
        private string Id_token;
        private string XAuthToken;

        private string response = @"B§
            ]eyJhbGciOiJIUzI1NiJ9.MTA5MDE1MjQwNDU3MTIzMzU0MTI3.m7adSZIwYj0stG1ro_ZEpV7Q31moCBl2HAvOUMjnNbY$82fd8255-5e23-4696-a51f-7023a2c3ac11" +
                                  "\"54ab923bf0bacdf654867588*¿ß";

        public string GetXAuthToken()
        {
            return XAuthToken;
        }

        public void Authenticate()
        {
            // var response = new TinderEndpoint.RestMethods(TinderAPI.Authenticate).Post()

        }
    }
}
