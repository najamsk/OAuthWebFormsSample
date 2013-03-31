using Microsoft.AspNet.Membership.OpenAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oauthNew.App_Start
{
    internal static class AuthConfig
    {
        public static void RegisterOpenAuth()
        {
            // See http://go.microsoft.com/fwlink/?LinkId=252803 for details on setting up this ASP.NET
            // application to support logging in via external services.

            //OpenAuth.AuthenticationClients.AddTwitter(
            //    consumerKey: "yrfyOXJsGoCMi85PYqdw",
            //    consumerSecret: "UrNfbBHUxh0sKtVMTzv72mv6WsBsWIlATvuA4Q8zVg");

            //OpenAuth.AuthenticationClients.AddFacebook(
            //    appId: "your Facebook app id",
            //    appSecret: "your Facebook app secret");

            //OpenAuth.AuthenticationClients.AddMicrosoft(
            //    clientId: "00000000480E7E87",
            //    clientSecret: "8beBDlTiq1be02txqaq2toTOfLaDlsZ4");

            OpenAuth.AuthenticationClients.AddGoogle();
        }
    }

}