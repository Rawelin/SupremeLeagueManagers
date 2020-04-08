using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace SupremeLeagueManager.Models.Global
{
    public class ThisServer
    {
        IPHostEntry ipHostInfo;
        IPAddress ipAddress;

        public ThisServer()
        {
            ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
            ipAddress = ipHostInfo.AddressList[0];
        }

        public string GetIPAddress()
        {
            return ipAddress.ToString();
        }

        public UriBuilder GetUrl()
        {
            return new UriBuilder(HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Host, HttpContext.Current.Request.Url.Port);
        }
    }
}