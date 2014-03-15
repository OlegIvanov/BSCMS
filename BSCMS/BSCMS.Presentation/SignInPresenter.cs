using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSCMS.Presentation
{
    public class SignInPresenter
    {
        private ISignInView _signInView;

        public SignInPresenter(ISignInView signInView)
        {
            _signInView = signInView;
        }
    }
}
