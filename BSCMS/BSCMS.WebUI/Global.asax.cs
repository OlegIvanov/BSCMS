using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using BSCMS.Infrastructure.Authentication;
using System.Threading;

namespace BSCMS.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ContainerBootstrapper.BootstrapStructureMap();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                HttpCookie authenticationCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket decryptedTicket = FormsAuthentication.Decrypt(authenticationCookie.Value);

                BSPrincipal bsPrincipal = new BSPrincipal(int.Parse(decryptedTicket.Name), decryptedTicket.UserData);

                HttpContext.Current.User = bsPrincipal;
                Thread.CurrentPrincipal = bsPrincipal;
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}