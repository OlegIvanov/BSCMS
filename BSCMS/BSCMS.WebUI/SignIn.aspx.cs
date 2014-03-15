using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSCMS.Presentation;

namespace BSCMS.WebUI
{
    public partial class SignIn : System.Web.UI.Page, ISignInView
    {
        private SignInPresenter _presenter;

        protected void PageInit(object sender, EventArgs e)
        {
            _presenter = new SignInPresenter(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string UserName
        {
            get { return userName.Text; }
        }

        public string UserPassword
        {
            get { return userPassword.Text; }
        }
    }
}