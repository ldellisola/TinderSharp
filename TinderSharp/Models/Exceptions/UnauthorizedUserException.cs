using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.Exceptions
{
    public class UnauthorizedUserException : Exception
    {
        public UnauthorizedUserException()
            :base("The X-Auth-Token is no longer valid. You need to log in again"){}
    }
}


