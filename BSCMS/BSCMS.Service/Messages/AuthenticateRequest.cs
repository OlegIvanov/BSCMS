using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Service.Messages
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
