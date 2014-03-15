using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Presentation
{
    public interface ISignInView
    {
        string UserName { get; }
        string UserPassword { get; }
    }
}
