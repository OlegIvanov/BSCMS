using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public interface IUserRepository
    {
        User FindBy(UserAuthenticationQuery userAuthenticationQuery);
    }
}
