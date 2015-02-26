using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace PersonalWebsite.Code
{
    public static class Tools
    {
        public static string RootURL
        {
            get
            {
                HttpRequest request = HttpContext.Current.Request;
                return string.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, HttpRuntime.AppDomainAppVirtualPath);
            }
        }

        public static string SecurityToken
        {
            get
            {
                string token1, token2;
                AntiForgery.GetTokens(null, out token1, out token2);
                return token1 + "-" + token2;
            }
        }

    }
}