using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service;
using BSCMS.Service.Messages;

namespace BSCMS.Presentation
{
    public class SignInPresenter
    {
        private ISignInView _signInView;

        private AuthenticationService _authenticationService;

        public SignInPresenter(ISignInView signInView, AuthenticationService authenticationService)
        {
            _signInView = signInView;
            _authenticationService = authenticationService;
        }

        public void SignIn()
        {
            AuthenticateRequest authenticateRequest = new AuthenticateRequest
            {
                Username = _signInView.Username,
                Password = _signInView.Password
            };
            AuthenticateResponse authenticateResponse = _authenticationService.SignIn(authenticateRequest);
        }
    }
}
