using BSCMS.Infrastructure.Authentication;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class SignInPresenter
    {
        private ISignInView _signInView;
        private AuthenticationService _authenticationService;
        private IFormsAuthentication _formsAuthentication;

        public SignInPresenter(ISignInView signInView, AuthenticationService authenticationService, IFormsAuthentication formsAuthentication)
        {
            _signInView = signInView;
            _authenticationService = authenticationService;
            _formsAuthentication = formsAuthentication;
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
            }
        }
    }
}
