using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                            HttpContext.Current.Response.Redirect("~/Views/Admin/Index.aspx");
                        break;
                    }
            }
        }
    }
}
