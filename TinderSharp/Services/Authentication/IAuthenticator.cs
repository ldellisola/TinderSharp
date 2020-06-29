namespace TinderSharp.Services.Authentication
{
    public interface IAuthenticator
    {
        string GetXAuthToken();
        void Authenticate();
    }
}