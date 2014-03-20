using System;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using BSCMS.Infrastructure.Authentication;
using BSCMS.Infrastructure.Configuration;
using StructureMap;

namespace BSCMS.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Admin_Home", "Admin", "~/Views/Admin/Index.aspx");
            routes.MapPageRoute("Admin_SignIn", "Admin/SignIn", "~/Views/Admin/SignIn.aspx");
            routes.MapPageRoute("Admin_AddBook", "Admin/AddBook", "~/Views/Admin/AddBook.aspx");
            routes.MapPageRoute("Admin_EditBook", "Admin/EditBook/{BookId}", "~/Views/Admin/EditBook.aspx");

            routes.MapPageRoute("User_Home", "", "~/Views/Home/Index.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);

            ContainerBootstrapper.BootstrapStructureMap();

            ApplicationSettingsFactory.InitializeApplicationSettingsFactory(ObjectFactory.GetInstance<IApplicationSettings>());
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