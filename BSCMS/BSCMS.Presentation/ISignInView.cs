using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Presentation
{
    public interface ISignInView
    {
        string Username { get; }
        string Password { get; }
        string AuthenticationError { set; }
    }
}
