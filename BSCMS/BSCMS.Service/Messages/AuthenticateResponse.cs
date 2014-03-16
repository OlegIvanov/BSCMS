using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Service.Messages
{
    public class AuthenticateResponse
    {
        public bool IsAuthenticated { get; set; }
        public string AuthenticationToken { get; set; }
        public string Username { get; set; }
    }
}
