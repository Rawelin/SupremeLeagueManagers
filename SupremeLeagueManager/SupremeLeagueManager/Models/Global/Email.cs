using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Global
{
    public static class Email
    {
        public static string RegistrationEmail(UriBuilder uriBuilder, string pass, int idUser)
        {
            string eMailBody = string.Empty;

            uriBuilder.Path = "SignIn/SignIn";
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            query["password"] = pass;
            query["idUser"] = idUser.ToString();
            uriBuilder.Query = query.ToString();

            eMailBody = "<div><h4> Welcome to the Supreme League Manager! </h4><br/>";
            eMailBody += "<p> To complete registration go to the link below: </p><br>";
            eMailBody += "<p> To complete registration go to the link below: </p><br>";
            eMailBody += "< a href = " + uriBuilder.Query.ToString() + " > Registration </ a >";

            return eMailBody;
        }
    }
}