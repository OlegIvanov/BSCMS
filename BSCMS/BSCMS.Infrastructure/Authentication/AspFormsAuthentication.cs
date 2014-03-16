using System.Web.Security;

namespace BSCMS.Infrastructure.Authentication
{
    public class AspFormsAuthentication : IFormsAuthentication
    {
        public void SetAuthenticationToken(string token)
        {
            FormsAuthentication.SetAuthCookie(token, false);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
