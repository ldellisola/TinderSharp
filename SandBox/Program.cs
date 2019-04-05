using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string tok = "EAAGm0PX4ZCpsBAJFwyGrVfczceXoGZA7QemKnCZCWOg9s8z54FIhBzmMEtwWEMowg518uzHIaBMxluBaxod70kVlvpL3LTJ5pTvaanNKZAk0qSuMnCdX8CIQRJK14qtTDbuph8NZAmX61ZBwTdzAUMQu8d0S7rGGnQk6bFWBwO8tcaEXV55QhZCs5lee6FEJCwZD";

            var usr = TinderSharp.Services.Authenticator.Authenticate(tok, 1605746836);


            var up = TinderSharp.Services.User.GetUpdates(usr.Token,new DateTime(2018,12,30));




            int a = 0;
            a++;

        }
    }
}


