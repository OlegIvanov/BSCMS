using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Threading;

namespace BSCMS.Infrastructure.Authentication
{
    public class BSIdentity : IIdentity
    {
        private int _userId;
        private string _userName;

        public BSIdentity(int userId, string userName)
        {
            _userId = userId;
            _userName = userName;
        }

        public string AuthenticationType
        {
            get { return "BookStore Authentication"; }
        }

        public bool IsAuthenticated
        {
            get { return _userId != 0; }
        }

        public string Name
        {
            get { return _userId.ToString(); }
        }

        public string UserName
        {
            get { return _userName; }
        }

        public static BSIdentity Current
        {
            get 
            {
                if (Thread.CurrentPrincipal != null && Thread.CurrentPrincipal.Identity != null)
                    return Thread.CurrentPrincipal.Identity as BSIdentity;
                else
                    return null;
            }
        }
    }
}
