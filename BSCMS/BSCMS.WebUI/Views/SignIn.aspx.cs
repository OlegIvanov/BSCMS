using System;
using BSCMS.Infrastructure.Authentication;
using BSCMS.Presentation;
using BSCMS.Service;
using StructureMap;

namespace BSCMS.WebUI.Views
{
    public partial class SignIn : System.Web.UI.Page, ISignInView
    {
        private SignInPresenter _presenter;

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new SignInPresenter(this, ObjectFactory.GetInstance<AuthenticationService>(), new AspFormsAuthentication());

            this.signIn.Click += new EventHandler(signIn_Click);
        }

        protected void signIn_Click(object sender, EventArgs e)
        {
            _presenter.SignIn();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public string Username
        {
            get { return userName.Text; }
        }

        public string Password
        {
            get { return userPassword.Text; }
        }
    }
}