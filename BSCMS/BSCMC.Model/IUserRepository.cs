using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMC.Model
{
    public interface IUserRepository
    {
        User FindBy(UserAuthenticationQuery userAuthenticationQuery);
    }
}
