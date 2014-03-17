using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace BSCMS.Infrastructure.Authentication
{
    public class BSPrincipal : IPrincipal
    {
        private BSIdentity _identity;

        public BSPrincipal(int userId, string userName)
        {
            _identity = new BSIdentity(userId, userName);
        }

        public IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            return false;
        }
    }
}
