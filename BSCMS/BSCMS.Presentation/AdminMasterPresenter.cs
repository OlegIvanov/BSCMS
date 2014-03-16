using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Infrastructure.Authentication;
using BSCMS.Presentation.Navigation;

namespace BSCMS.Presentation
{
    public class AdminMasterPresenter
    {
        private IFormsAuthentication _formsAuthentication;
        private IPageNavigator _pageNavigator;

        public AdminMasterPresenter(IFormsAuthentication formsAuthentication, IPageNavigator pageNavigator) 
        {
            _formsAuthentication = formsAuthentication;
            _pageNavigator = pageNavigator;
        }

        public void SignOut()
        {
            _formsAuthentication.SignOut();
            _pageNavigator.NavigateTo(PageDirectory.AdminHome);
        }
    }
}
