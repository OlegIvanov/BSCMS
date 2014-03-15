using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMC.Model
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User FindBy(UserAuthenticationQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
