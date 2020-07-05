using System;

namespace TinderSharp.Models.Exceptions
{
    public class UnkownTinderException : Exception
    {
        public UnkownTinderException(int errorCode)
            :base("Tinder returned an unknown error code: " + errorCode ){}

    }
}