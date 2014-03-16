using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.Messages;
using BSCMS.Model;

namespace BSCMS.Service
{
    public class AuthenticationService
    {
        private IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public AuthenticateResponse SignIn(AuthenticateRequest authenticateRequest)
        {
            UserAuthenticationQuery userAuthenticationQuery = new UserAuthenticationQuery 
            { 
                Username = authenticateRequest.Username,
                PasswordHash = HashCalculator.HashPassword(authenticateRequest.Password)
            };

            User user = _userRepository.FindBy(userAuthenticationQuery);

            AuthenticateResponse authenticateResponse = new AuthenticateResponse();
            authenticateResponse.IsAuthenticated = false;

            if (user != null)
            {
                authenticateResponse.AuthenticationToken = user.Id.ToString();
                authenticateResponse.Username = user.Username;
                authenticateResponse.IsAuthenticated = true;
            }

            return authenticateResponse;
        }
    }
}
