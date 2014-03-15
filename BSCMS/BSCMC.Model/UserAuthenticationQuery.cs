using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMC.Model
{
    public class UserAuthenticationQuery
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
