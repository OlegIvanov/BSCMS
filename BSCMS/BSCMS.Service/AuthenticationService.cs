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
        private UserService _userService;

        public AuthenticationService(UserService userService)
        {
            _userService = userService;
        }

        public AuthenticateResponse SignIn(AuthenticateRequest authenticateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
