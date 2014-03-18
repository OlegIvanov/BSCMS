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
        private IAdminMasterView _adminMasterView;
        private IFormsAuthentication _formsAuthentication;
        private IPageNavigator _pageNavigator;

        public AdminMasterPresenter(IAdminMasterView adminMasterView, IFormsAuthentication formsAuthentication, IPageNavigator pageNavigator) 
        {
            _adminMasterView = adminMasterView;
            _formsAuthentication = formsAuthentication;
            _pageNavigator = pageNavigator;
        }

        public void SignOut()
        {
            _formsAuthentication.SignOut();
            _pageNavigator.NavigateTo(PageDirectory.AdminHome);
        }

        public void Display()
        {
            if (BSIdentity.Current != null && BSIdentity.Current.IsAuthenticated)
                _adminMasterView.Username = BSIdentity.Current.UserName;
            else
                _adminMasterView.Username = "Anonymous";
        }
    }
}
