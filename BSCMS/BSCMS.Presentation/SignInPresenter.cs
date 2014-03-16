using BSCMS.Infrastructure.Authentication;
using BSCMS.Presentation.Navigation;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class SignInPresenter
    {
        private ISignInView _signInView;
        private AuthenticationService _authenticationService;
        private IFormsAuthentication _formsAuthentication;
        private IPageNavigator _pageNavigator;

        public SignInPresenter(ISignInView signInView, AuthenticationService authenticationService, IFormsAuthentication formsAuthentication, IPageNavigator pageNavigator)
        {
            _signInView = signInView;
            _authenticationService = authenticationService;
            _formsAuthentication = formsAuthentication;
            _pageNavigator = pageNavigator;
        }

        public void SignIn()
        {
            AuthenticateRequest authenticateRequest = new AuthenticateRequest
            {
                Username = _signInView.Username,
                Password = _signInView.Password
            };

            AuthenticateResponse authenticateResponse = _authenticationService.SignIn(authenticateRequest);

            if (authenticateResponse.IsAuthenticated) 
            {
                _formsAuthentication.SetAuthenticationToken(authenticateResponse.AuthenticationToken);
                _pageNavigator.NavigateTo(PageDirectory.AuthenticationReturnUrl);
            }
        }
    }
}
