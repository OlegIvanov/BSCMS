using System;
using System.Web;
using System.Web.Security;

namespace BSCMS.Infrastructure.Authentication
{
    public class AspFormsAuthentication : IFormsAuthentication
    {
        public void SetAuthenticationToken(string token, string userName)
        {
            FormsAuthenticationTicket authenticationTicket = new FormsAuthenticationTicket(1, token, DateTime.Now, DateTime.Now.Add(FormsAuthentication.Timeout), false, userName);
            string encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);

            HttpCookie authenticationCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) 
            { 
                Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Current.Response.Cookies.Add(authenticationCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
