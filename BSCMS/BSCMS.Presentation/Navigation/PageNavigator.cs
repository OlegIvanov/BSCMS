using System;
using System.Web;

namespace BSCMS.Presentation.Navigation
{
    public class PageNavigator : IPageNavigator
    {
        public void NavigateTo(PageDirectory pageDirectory)
        {
            switch (pageDirectory)
            { 
                case PageDirectory.AuthenticationReturnUrl:
                    {
                        string returnUrl = HttpContext.Current.Request["ReturnUrl"];
                        if (!String.IsNullOrEmpty(returnUrl))
                            HttpContext.Current.Response.Redirect(returnUrl);
                        else
                            NavigateTo(PageDirectory.AdminHome);
                        break;
                    }
                case PageDirectory.AdminHome:
                    {
                        HttpContext.Current.Response.RedirectToRoute("Admin_Home");
                        break;
                    }
            }
        }
    }
}
