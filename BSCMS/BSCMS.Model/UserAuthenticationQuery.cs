using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Model
{
    public class UserAuthenticationQuery
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
