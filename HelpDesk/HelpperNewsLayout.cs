using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk
{
    public static class HelpperNewsLayout
    {



        public static string ChkLogin(string user)
        {
            if (user.Equals("") || user.Equals(null) || user == null)
            {
                return @"~/Views/Shared/_NewsLayoutWithoutLogin.cshtml";
            }
            else
            {
                return @"~/Views/Shared/_NewsLayoutWithLogin.cshtml";

            }
        }
    }
}
