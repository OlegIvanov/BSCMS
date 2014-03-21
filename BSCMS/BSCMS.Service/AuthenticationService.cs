using BSCMS.Authentication.Infrastructure;
using BSCMS.Model;
using BSCMS.Service.Messages;

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
            User user = _userRepository.FindBy(authenticateRequest.Username, HashCalculator.HashPassword(authenticateRequest.Password));

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
