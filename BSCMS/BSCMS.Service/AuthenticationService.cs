using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BSCMS.Service.Messages;
using BSCMC.Model;

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
            throw new NotImplementedException();
        }
    }
}
