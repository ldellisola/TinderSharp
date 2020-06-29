using System;

namespace TinderSharp.Services.Messages
{
    public interface ISongMessage
    {
        Uri GetUri();
        string GetSongId();
    }
}