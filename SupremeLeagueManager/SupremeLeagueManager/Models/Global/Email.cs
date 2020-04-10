using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Global
{
    public static class Email
    {
        public static string RegistrationEmail(UriBuilder uriBuilder, byte[] pass, int idUser)
        {
            string eMailBody = string.Empty;
            char[] padding = { '=' };

            uriBuilder.Path = "SignIn/Confirmation";
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            //query["password"] = System.Convert.ToBase64String(pass).TrimEnd(padding).Replace('+', '-').Replace('/', '_');
            query["password"] = System.Convert.ToBase64String(pass);
            //query["password"] = BitConverter.ToString(pass);

            query["idUser"] = idUser.ToString();
            uriBuilder.Query = query.ToString();

            eMailBody = "<div><h4> Welcome to the Supreme League Manager! </h4><br/>";
            eMailBody += "<p> To complete registration go to the link below: </p><br/>";
            eMailBody += "<a href =" + uriBuilder.ToString() + "> Registration </a>";

            return eMailBody;
        }
    }
}